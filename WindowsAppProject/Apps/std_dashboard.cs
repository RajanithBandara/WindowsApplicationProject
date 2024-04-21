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
using WindowsAppProject.Apps.usercontrol_studentdash;

namespace WindowsAppProject.Apps
{
    public partial class std_dashboard : Form
    {
        public std_dashboard()
        {
            InitializeComponent();
        }
        private void addusercontrol(UserControl usrctrl)
        {
            usrctrl.Dock = DockStyle.Fill;
            mainpanelstd.Controls.Clear();
            mainpanelstd.Controls.Add(usrctrl);
        }

        private string connectionstring = dbconnection.Instance.ConnectionString;
        private void mainpanelstd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            module_view module_view = new module_view();
            addusercontrol(module_view);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            testchart chartview = new testchart();
            addusercontrol(chartview);
        }

        private void std_dashboard_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Text = StudentIdGetter.StudentId;
            addardata();
            studentnameget();
        }
        
        private void addardata()
        {
            string username = session.Username;
            textBox5.Text = username;
            using (OleDbConnection conn = new OleDbConnection(connectionstring))
            {
                string sql = "SELECT * FROM aruserdata WHERE username = @username";
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox4.Text = reader["Fullname"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void rjButton1_mousehover(object sender, EventArgs e)
        {
            label1.Visible=true;
        }

        private void rjButton1_mouseleave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void rjButton2_mousehover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void rjButton2_mouseleave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void studentnameget()
        {
            string stdid = StudentIdGetter.StudentId;
            label3.Text = stdid;
            using (OleDbConnection conn = new OleDbConnection(connectionstring))
            {
                conn.Open();    
                string sql = "SELECT * FROM studentgpa WHERE studentid = @studentid";
                string sql2 = "SELECT student.StudentName, coursetable.coursename, student.StudentID FROM coursetable INNER JOIN student ON coursetable.courseid = student.courseid where studentid = @studentid;";

                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@studentid", stdid);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = reader["studentgpa"].ToString();
                        }
                    }
                }
                using (OleDbCommand cmd2 = new OleDbCommand(sql2, conn))
                {
                    cmd2.Parameters.AddWithValue("@studentid", stdid);
                    using (OleDbDataReader reader2 = cmd2.ExecuteReader())
                    {
                        if (reader2.Read())
                        {
                            textBox2.Text = reader2["StudentName"].ToString();
                            textBox3.Text = reader2["coursename"].ToString();
                        }
                        else
                        {
                            textBox2.Text = "No Name Assigned";
                            textBox3.Text = "No Course Assigned";
                        }
                    }
                }
                
                conn.Close();
            }
        }

        private void rjPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            remove_module rmv = new remove_module();
            rmv.Show();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            std_dashboard std_Dashboard = new std_dashboard();
            std_Dashboard.Show();
            studentnameget();
        }
    }
}
