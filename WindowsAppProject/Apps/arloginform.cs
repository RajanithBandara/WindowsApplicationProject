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
            button1.MouseHover += button1_MouseHover;
            button1.MouseLeave += button1_MouseLeave;
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        private string connectionstr = "Host=165.232.167.179;Port=5432;Username=postgres;Password=rajanith2003;Database=usersdb";

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = textBox1.Text; 
            string enteredPassword = textBox2.Text;

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionstr))
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
        private void button1_MouseHover(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
