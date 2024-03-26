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
    public partial class student_top_view : UserControl
    {
        public student_top_view()
        {
            InitializeComponent();
        }

        int yoffset = 0;

        public string connectionstr = dbconnection.Instance.ConnectionString;

        private void student_top_view_Load(object sender, EventArgs e)
        {
           loadstudentcontent();
        }
        private void loadstudentcontent()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionstr))
            {
                conn.Open();
                string sql = "SELECT student.StudentID, student.StudentName, studentgpa.StudentGPA, student.courseid\r\nFROM studentgpa INNER JOIN student ON studentgpa.StudentID = student.StudentID\r\nWHERE (((studentgpa.StudentGPA)>3.3));\r\n";
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string student_id = reader["StudentID"].ToString();
                            string student_name = reader["StudentName"].ToString();
                            float student_gpa = Convert.ToSingle(reader["StudentGPA"]);
                            string formatted_gpa = student_gpa.ToString("0.00");
                            string course_id = reader["courseid"].ToString();


                            Label lbl = new Label();
                            lbl.ForeColor = Color.White;
                            lbl.Location = new Point(40, 75 + yoffset);
                            lbl.BackColor = Color.Transparent;
                            lbl.Text = student_id;
                            lbl.AutoSize = false;
                            lbl.Height = 50;
                            lbl.Width = 100;
                            lbl.Font = new Font("Microsoft Sans Serif", 18);
                            panel1.Controls.Add(lbl);

                            Label lbl2 = new Label();
                            lbl2.ForeColor = Color.White;
                            lbl2.Location = new Point(50, 75 + yoffset);
                            lbl2.BackColor = Color.Transparent;
                            lbl2.Text = student_name;
                            lbl2.AutoSize = false;
                            lbl2.Height = 50;
                            lbl2.Width = 450;
                            lbl2.Font = new Font("Microsoft Sans Serif", 18);
                            panel2.Controls.Add(lbl2);

                            Label lbl3 = new Label();
                            lbl3.ForeColor = Color.White;
                            lbl3.Location = new Point(40, 75 + yoffset);
                            lbl3.BackColor = Color.Transparent;
                            lbl3.Text = formatted_gpa;
                            lbl3.AutoSize = false;
                            lbl3.Height = 50;
                            lbl3.Width = 136;
                            lbl3.Font = new Font("Microsoft Sans Serif", 18);
                            panel3.Controls.Add(lbl3);
                            yoffset = yoffset + 50;
                        }
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No records found.");
                        }
                    }
                }
            }
        }
        }
}
