using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.SqlClient;

namespace WindowsAppProject.Apps
{
    public partial class adminloginform : Form
    {
        public adminloginform()
        {
            InitializeComponent();
            button1.MouseHover += button1_MousHover;
            button1.MouseLeave += button1_MouseLeave;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            string connectionstr = dbconnection.Instance.ConnectionString;
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionstr))
            {
                conn.Open();

                string sql = "SELECT password FROM public.adminuser WHERE username = @username";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashedPasswordFromDatabase = reader.GetString(0);

                            if (password == hashedPasswordFromDatabase)
                            {
                                MessageBox.Show("Login successful!");
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
        }
        private void button1_MousHover(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
