using System;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsAppProject.Apps
{
    public partial class profile_settings : Form
    {
        public profile_settings()
        {
            InitializeComponent();
        }

        private void profile_settings_Load(object sender, EventArgs e)
        {
            userdataload();
        }

        private void userdataload()
        {
            string connectionstr = dbconnection.Instance.ConnectionString;
            string username = session.Username;

            using (OleDbConnection conn = new OleDbConnection(connectionstr))
            {
                conn.Open();
                string sqlcmd = "SELECT aruserdata.Fullname, aruserdata.username, aruserdata.email FROM aruserdata WHERE username = @username";

                using (OleDbCommand cmd = new OleDbCommand(sqlcmd, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    try
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fullname = reader.GetString(0);
                                string user = reader.GetString(1);
                                string email = reader.GetString(2);

                                textBox1.Text = fullname;
                                textBox5.Text = user;
                                textBox4.Text = email;
                            }
                            else
                            {
                                MessageBox.Show("No user data found for the current username.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            validationprocess();
        }

        private void validationprocess()
        {
            string connectionstr = dbconnection.Instance.ConnectionString;
            string username = session.Username;

            using (OleDbConnection conn = new OleDbConnection(connectionstr))
            {
                conn.Open();
                string sqlcmd = "SELECT aruserdata.Fullname, aruserdata.username, aruserdata.email FROM aruserdata WHERE username = @username";

                using (OleDbCommand cmd = new OleDbCommand(sqlcmd, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    try
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fullname = reader.GetString(0);
                                string user = reader.GetString(1);
                                string email = reader.GetString(2);

                                if (fullname != textBox1.Text)
                                {
                                    string updatefullname = "UPDATE aruserdata SET Fullname = @fullname WHERE username = @username";
                                    UpdateColumn(conn, updatefullname, "@fullname", textBox1.Text, username);
                                    MessageBox.Show("Full Name changed Successfully");
                                }

                                if (user != textBox5.Text)
                                {
                                    string updateUsername = "UPDATE aruserdata SET username = @username WHERE username = @oldUsername";
                                    UpdateColumn(conn, updateUsername, "@username", textBox5.Text, username);
                                    MessageBox.Show("Username changed Successfully");
                                    session.Username = textBox5.Text;
                                }

                                if (email != textBox4.Text)
                                {
                                    string updateEmail = "UPDATE aruserdata SET email = @email WHERE username = @username";
                                    UpdateColumn(conn, updateEmail, "@email", textBox4.Text, username);
                                    MessageBox.Show("Email changed Successfully");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }

                string sql = "SELECT pasword FROM aruserdata WHERE username = @username";
                if (!string.IsNullOrEmpty(textBox6.Text))
                {
                    string enteredPassword = textBox6.Text;
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
                                    string newpwd = textBox2.Text;
                                    string newpwdret = textBox3.Text;
                                    if (newpwd == newpwdret)
                                    {
                                        string hashedNewPassword = HashPassword(newpwd);
                                        string updatePassword = "UPDATE aruserdata SET pasword = @password WHERE username = @username";
                                        UpdateColumn(conn, updatePassword, "@password", hashedNewPassword, username);
                                        MessageBox.Show("Passwords changed Successfully");
                                    }
                                    else
                                    {
                                        MessageBox.Show("New passwords do not match.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect current password.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username.");
                            }
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

        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void UpdateColumn(OleDbConnection conn, string updateQuery, string parameterName, string newValue, string username)
        {
            using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
            {
                updateCmd.Parameters.AddWithValue(parameterName, newValue);
                updateCmd.Parameters.AddWithValue("@username", username);
                updateCmd.ExecuteNonQuery();
            }
        }
    }
}
