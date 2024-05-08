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

                string courseCheckQuery = "SELECT COUNT(*) FROM coursetable WHERE courseid = @CourseID";
                using (OleDbCommand checkCmd = new OleDbCommand(courseCheckQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@CourseID", studentcourse);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Course not available. Please enter a valid course ID.");
                        return; 
                    }
                }

                string studentInsertQuery = "INSERT INTO student VALUES(@StudentID, @StudentName, @CourseID)";
                string studentGPAInsertQuery = "INSERT INTO studentgpa(studentid, studentgpa) VALUES(@StudentID, @StudentGPA)";

                using (OleDbCommand cmd = new OleDbCommand(studentInsertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentid);
                    cmd.Parameters.AddWithValue("@StudentName", studentname);
                    cmd.Parameters.AddWithValue("@CourseID", studentcourse);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Registered Successfully");

                    using (OleDbCommand cmd2 = new OleDbCommand(studentGPAInsertQuery, conn))
                    {
                        cmd2.Parameters.AddWithValue("@StudentID", studentid);
                        cmd2.Parameters.AddWithValue("@StudentGPA", 0);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("GPA related stuff ready");
                    }
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
