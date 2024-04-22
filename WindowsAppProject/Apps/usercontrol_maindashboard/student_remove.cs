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
    public partial class student_remove : UserControl
    {
        public student_remove()
        {
            InitializeComponent();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            removestudent();
        }

        private void removestudent()
        {
            string connectionstr = dbconnection.Instance.ConnectionString;
            using (OleDbConnection conn = new OleDbConnection(connectionstr))
            {
                string studentid = textBox1.Text;
                if (studentid == string.Empty)
                {
                    MessageBox.Show("Please Enter a Student ID ");
                    return;
                }

                try
                {
                    conn.Open();

                    string sqlcmd = "DELETE FROM studentmoduleresult WHERE StudentID = @studentid";
                    using (OleDbCommand cmd = new OleDbCommand(sqlcmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentid", studentid);
                        cmd.ExecuteNonQuery();
                    }

                    string sqlcmd2 = "DELETE FROM studentgpa WHERE StudentID = @studentid";
                    using (OleDbCommand cmd = new OleDbCommand(sqlcmd2, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentid", studentid);
                        cmd.ExecuteNonQuery();
                    }

                    string sqlcmd3 = "DELETE FROM student WHERE StudentID = @studentid";
                    using (OleDbCommand cmd = new OleDbCommand(sqlcmd3, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentid", studentid);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Student data deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
