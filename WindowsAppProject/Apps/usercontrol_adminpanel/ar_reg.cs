using Npgsql;
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

namespace WindowsAppProject.Apps.usercontrol_adminpanel
{
    public partial class ar_reg : UserControl
    {
        public ar_reg()
        {
            InitializeComponent();
            Hint1.MouseHover += Hint1_MouseHover;
            Hint1.MouseLeave += Hint1_MouseLeave;
            rjButton1.MouseHover += rjButton1_Mousehover;
            rjButton1.MouseLeave += rjButton1_MouseLeave;
        }



        private string connectionstr = dbconnection.Instance.ConnectionString;
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstr = dbconnection.Instance.ConnectionString;
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionstr))
            {
                conn.Open();

                String username = textBox1.Text;
                String password = textBox2.Text;
                String retypepassword = textBox3.Text;
                String email = textBox4.Text;

                string hashedPassword = HashPassword(password);

                if (password == retypepassword && username != "")
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
            }

        private void ar_reg_Load(object sender, EventArgs e)
        {
            string connectionstr = dbconnection.Instance.ConnectionString;
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionstr))
            {
                conn.Open();
                MessageBox.Show("Network connection successful");
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
        private void label9_Click(object sender, EventArgs e)
        {
            arloginform arlogform = new arloginform();
            arlogform.Show();
        }

        private void Hint1_MouseHover(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';

        }
        private void Hint1_MouseLeave(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
        private void rjButton1_Mousehover(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '\0';
        }
        private void rjButton1_MouseLeave(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            string connectionstr = dbconnection.Instance.ConnectionString;
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionstr))
            {
                conn.Open();

                String username = textBox1.Text;
                String password = textBox2.Text;
                String retypepassword = textBox3.Text;
                String email = textBox4.Text;

                string hashedPassword = HashPassword(password);

                if (password == retypepassword && username != "")
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
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
          
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
