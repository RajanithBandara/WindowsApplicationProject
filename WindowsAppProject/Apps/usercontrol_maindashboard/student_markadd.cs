using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppProject.Apps.usercontrol_maindashboard
{
    public partial class student_markadd : UserControl
    {
        public student_markadd()
        {
            InitializeComponent();
        }
        private string connectionstr = dbconnection.Instance.ConnectionString;

        private void rjButton2_Click(object sender, EventArgs e)
        {
            additiondetailsandchecking();
        }
        private void additiondetailsandchecking()
        {
            string stdid = textBox1.Text;
            string modlecode = textBox2.Text;
            string modlename = textBox3.Text;

            using (OleDbConnection checkconn = new OleDbConnection(connectionstr))
            {
                checkconn.Open();
                string dbquery = "Select * from student where studentid = @stdid";
                using (OleDbCommand checkcmd = new OleDbCommand(dbquery, checkconn))
                {
                    checkcmd.Parameters.AddWithValue("@stdid", stdid);
                    using (OleDbDataReader reader = checkcmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Student ID not found. Please register the relevant student first");
                            return;
                        }
                    }
                }
                checkconn.Close();
            }

            if (!int.TryParse(textBox4.Text, out int semesterValue) || !int.TryParse(textBox5.Text, out int modlecreditsValue))
            {
                MessageBox.Show("Invalid numeric values for semester or module credits.");
                return;
            }

            string modlegrades = textBox6.Text;

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionstr))
                {
                    conn.Open();

                    string sqlQuery = "INSERT INTO studentmoduleresult VALUES (@stdid, @modlecode, @modlename, @semester, @modlecredits, @modlegrades)";

                    using (OleDbCommand cmd = new OleDbCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@stdid", stdid);
                        cmd.Parameters.AddWithValue("@modlecode", modlecode);
                        cmd.Parameters.AddWithValue("@modlename", modlename);
                        cmd.Parameters.AddWithValue("@semester", semesterValue);
                        cmd.Parameters.AddWithValue("@modlecredits", modlecreditsValue);
                        cmd.Parameters.AddWithValue("@modlegrades", modlegrades);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Inserted successfully!");
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox6.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No rows affected.");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
