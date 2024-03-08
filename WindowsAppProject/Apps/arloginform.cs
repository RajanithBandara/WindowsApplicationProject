using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsAppProject.Apps
{
    public partial class arloginform : Form
    {
        public arloginform()
        {
            InitializeComponent();
            Hint1.MouseHover += Hint1_MouseHover;
            Hint1.MouseLeave += Hint1_MouseLeave;
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = textBox1.Text; 
            string enteredPassword = textBox2.Text;

            using (NpgsqlConnection conn = new NpgsqlConnection())
            {
                conn.Open();
                string sql = "SELECT password FROM public.aruserdata WHERE username = @username";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", usernameOrEmail);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashedPasswordFromDatabase = reader.GetString(0);

                            if (VerifyPassword(enteredPassword, hashedPasswordFromDatabase))
                            {
                                MessageBox.Show("Login successful!");
                            }
                            else
                            {                               
                                MessageBox.Show("Incorrect username or password.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or email.");
                        }
                    }
                }
            }

        }

        private static bool VerifyPassword(string enteredPassword, string hashedPasswordFromDatabase)
        {
            
            string hashedEnteredPassword = HashPassword(enteredPassword);
            return hashedEnteredPassword == hashedPasswordFromDatabase;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void Hint1_MouseHover(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
        }
        private void Hint1_MouseLeave(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void Hint1_Click(object sender, EventArgs e)
        {

        }

        private void arloginform_Load(object sender, EventArgs e)
        {
            string connectionstring = dbconnection.Instance.ConnectionString;
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionstring))
            {
                conn.Open();
                MessageBox.Show("Connection successful!");
            }
        }
    }
}
