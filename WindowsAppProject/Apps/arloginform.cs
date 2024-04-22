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
using System.Data.OleDb;

namespace WindowsAppProject.Apps
{
    public partial class arloginform : Form
    {
        public arloginform()
        {
            InitializeComponent();
            //this.KeyPress += arloginform_KeyPress;
            this.KeyPreview = true;
            this.KeyPress += task_enter;
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

        private void task_enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                enterdata();
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            enterdata();
        }
        private void enterdata()
        {
            session.Username = textBox1.Text;
            string username = textBox1.Text;
            string enteredPassword = textBox2.Text;
            string connectionstring = dbconnection.Instance.ConnectionString;
            using (OleDbConnection conn = new OleDbConnection(connectionstring))
            {
                conn.Open();

                string sql = "SELECT pasword FROM aruserdata WHERE username = @username";

                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashedPasswordFromDatabase = reader.GetString(0);

                            if (VerifyPassword(enteredPassword, hashedPasswordFromDatabase))
                            {
                                loading_screen loaddash = new loading_screen();
                                this.Hide();
                                loaddash.Show();
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
                conn.Close();
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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            adminloginform adminlogin = new adminloginform();
            adminlogin.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            ardata_changeform ardata_Changeform = new ardata_changeform();
            ardata_Changeform.Show();
        }
    }
}
