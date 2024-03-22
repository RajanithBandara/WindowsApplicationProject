using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppProject.Apps.usercontrol_maindashboard
{
    public partial class student_register_usrctrl : UserControl
    {
        public student_register_usrctrl()
        {
            InitializeComponent();
        }
        string connectstr = dbconnection.Instance.ConnectionString;
        private void rjButton1_Click(object sender, EventArgs e)
        {
            string studentid = textBox1.Text;
            string studentname = textBox2.Text;
            string studentcourse = textBox3.Text;

            using (OleDbConnection conn = new OleDbConnection(connectstr))
            {
                conn.Open();
                string sql = "INSERT INTO student VALUES(@StudentID, @StudentName, @courseid)";
                string sql2 = "Select * from coursetable where courseid = ";
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("StudentID", studentid);
                    cmd.Parameters.AddWithValue("StudentName", studentname);
                    cmd.Parameters.AddWithValue("courseid", studentcourse);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Registered Successfully");
                }
                conn.Close();
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
