using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsAppProject.Apps.usercontrol_coursedashboard
{
    public partial class courses_view : UserControl
    {
        public courses_view()
        {
            InitializeComponent();
        }
        public string connectstr = dbconnection.Instance.ConnectionString;
        public void display_courses()
        {
            int x = 0;
            int y = 0;
            int z = 0;
            using (OleDbConnection conn = new OleDbConnection(connectstr))
            {
                conn.Open();
                string sql = "SELECT coursename FROM coursetable";
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string course_name = reader["coursename"].ToString();
                            Label lbl = new Label();
                            lbl.ForeColor = Color.White;
                            lbl.Location = new Point(10,15 + x);
                            lbl.BackColor = Color.Transparent;
                            lbl.Text = course_name;
                            lbl.AutoSize = false;
                            lbl.Height = 50;
                            lbl.Width = 900;
                            lbl.Font = new Font("Microsoft Sans Serif", 18);
                            panel2.Controls.Add(lbl);
                            x += 50;
                        }
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No records found.");
                        }
                    }
                }
                string sql2 = "SELECT courseid FROM coursetable";
                using (OleDbDataReader reader2 = new OleDbCommand(sql2, conn).ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        string course_id = reader2["courseid"].ToString();
                        Label lbl2 = new Label();
                        lbl2.ForeColor = Color.White;
                        lbl2.Location = new Point(20, 15 + y);
                        lbl2.BackColor = Color.Transparent;
                        lbl2.Text = course_id;
                        lbl2.AutoSize = false;
                        lbl2.Height = 50;
                        lbl2.Width = 900;
                        lbl2.Font = new Font("Microsoft Sans Serif", 18);
                        panel1.Controls.Add(lbl2);
                        y += 50;
                    }
                    if (!reader2.HasRows)
                    {
                        MessageBox.Show("No records found.");
                    }
                }
                string sql3 = "SELECT credits FROM coursetable";
                using (OleDbDataReader reader3 = new OleDbCommand(sql3, conn).ExecuteReader())
                {
                    while (reader3.Read())
                    {
                        string course_credits = reader3["credits"].ToString();
                        Label lbl3 = new Label();
                        lbl3.ForeColor = Color.White;
                        lbl3.Location = new Point(50, 15 + z);
                        lbl3.BackColor = Color.Transparent;
                        lbl3.Text = course_credits;
                        lbl3.AutoSize = false;
                        lbl3.Height = 50;
                        lbl3.Width = 900;
                        lbl3.Font = new Font("Microsoft Sans Serif", 18);
                        panel3.Controls.Add(lbl3);
                        z += 50;
                    }
                    if (!reader3.HasRows)
                    {
                        MessageBox.Show("No records found.");
                    }
                }
                conn.Close();
            }
        }

        private void courses_view_Load(object sender, EventArgs e)
        {
            display_courses();
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            panel2.VerticalScroll.Value = panel1.VerticalScroll.Value;
            panel3.VerticalScroll.Value = panel1.VerticalScroll.Value;
        }
    }
}
