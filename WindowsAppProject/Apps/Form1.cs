using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Npgsql;

namespace WindowsAppProject.Apps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string connectionstr = "Host=165.232.167.179;Port=5432;Username=postgres;Password=rajanith2003;Database=usersdb";  

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;
            String retypepassword = textBox4.Text;
            String email = textBox3.Text;

            NpgsqlConnection conn = new NpgsqlConnection(connectionstr);
            conn.Open();
            string hashedPassword = HashPassword(password);

            if (password == retypepassword)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO public.aruserdata (username, password, email) VALUES (@username, @password, @email)", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Parameters.AddWithValue("@email", email);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Data Not Inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Password and Retype Password are not the same");
            }
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            arloginform arlogform = new arloginform();
            arlogform.Show();
        }
    }
}
