using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppProject.Apps
{
    public partial class ardata_changeform : Form
    {
        public ardata_changeform()
        {
            InitializeComponent();
        }

        private void ardata_changeform_Load(object sender, EventArgs e)
        {
            label12.Visible = false;
            label11.Visible = false;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            string connectionstr = dbconnection.Instance.ConnectionString;
            using (OleDbConnection conn = new OleDbConnection(connectionstr))
            {
                conn.Open();
                string fullname = textBox1.Text;
                string username = textBox5.Text;
                string password = textBox2.Text;

                string retypepassword = textBox3.Text;
                string email = textBox4.Text;

                string hashedPassword = HashPassword(password);

                if (password.Length >= 8 && password == retypepassword && username != "")
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO aruserdata(Fullname, username, pasword, email) VALUES (@fullname, @username, @password, @email)", conn);
                    cmd.Parameters.AddWithValue("@fullname", fullname);
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
                else if (password.Length < 8)
                {
                    MessageBox.Show("Password should be at least 8 characters long.");
                }
                else
                {
                    MessageBox.Show("Password and Retype Password are not the same");
                }
                conn.Close();
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

        private void rjButton3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;   
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label11.Visible = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label12.Visible = true;
        }
    }
}
