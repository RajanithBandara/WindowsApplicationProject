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

        public string connectionstr = dbconnection.Instance.ConnectionString;
        public int yoffset = 0;
        private async void student_top_view_Load(object sender, EventArgs e)
        {
            await Task.Run(() => loadstudentcontent());

        }
        private async void loadstudentcontent()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionstr))
                {
                    conn.Open();
                    string sql = "SELECT student.StudentID, student.StudentName, studentgpa.StudentGPA, student.courseid " +
                                 "FROM studentgpa INNER JOIN student ON studentgpa.StudentID = student.StudentID " +
                                 "WHERE studentgpa.StudentGPA > 3.3";
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

                                Invoke((MethodInvoker)delegate
                                {
                                    Label lbl = new Label();
                                    lbl.ForeColor = Color.White;
                                    lbl.Location = new Point(0, 75 + yoffset);
                                    lbl.BackColor = Color.FromArgb(132, 169, 172);
                                    lbl.Text = student_id;
                                    lbl.AutoSize = false;
                                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                                    lbl.Height = 50;
                                    lbl.Width = panel1.Width;
                                    lbl.Font = new Font("Microsoft Sans Serif", 18);
                                    panel1.Controls.Add(lbl);

                                    Label lbl2 = new Label();
                                    lbl2.ForeColor = Color.White;
                                    lbl2.Location = new Point(0, 75 + yoffset);
                                    lbl2.BackColor = Color.FromArgb(132, 169, 172);
                                    lbl2.Text = student_name;
                                    lbl2.TextAlign = ContentAlignment.MiddleCenter;
                                    lbl2.AutoSize = false;
                                    lbl2.Height = 50;
                                    lbl2.Width = panel2.Width;
                                    lbl2.Font = new Font("Microsoft Sans Serif", 18);
                                    panel2.Controls.Add(lbl2);

                                    Label lbl3 = new Label();
                                    lbl3.ForeColor = Color.White;
                                    lbl3.Location = new Point(0, 75 + yoffset);
                                    lbl3.BackColor = Color.FromArgb(132, 169, 172);
                                    lbl3.Text = course_id;
                                    lbl3.TextAlign = ContentAlignment.MiddleCenter;
                                    lbl3.AutoSize = false;
                                    lbl3.Height = 50;
                                    lbl3.Width = panel4.Width;
                                    lbl3.Font = new Font("Microsoft Sans Serif", 18);
                                    panel4.Controls.Add(lbl3);

                                    Label lbl4 = new Label();
                                    lbl4.ForeColor = Color.White;
                                    lbl4.Location = new Point(0, 75 + yoffset);
                                    lbl4.BackColor = Color.FromArgb(132, 169, 172);
                                    lbl4.Text = formatted_gpa;
                                    lbl4.TextAlign = ContentAlignment.MiddleCenter; 
                                    lbl4.AutoSize = false;
                                    lbl4.Height = 50;
                                    lbl4.Width = panel3.Width;
                                    lbl4.Font = new Font("Microsoft Sans Serif", 18);
                                    panel3.Controls.Add(lbl4);
                                    yoffset = yoffset + 57;
                                });
                            }
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No records found.");
                            }
                        }
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
