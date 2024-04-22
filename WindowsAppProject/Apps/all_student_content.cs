using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsAppProject.Apps
{
    public partial class all_student_content : Form
    {
        public all_student_content()
        {
            InitializeComponent();
            try
            {
                PopulateMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while populating menu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateMenu()
        {
            try
            {
                string connectionString = dbconnection.Instance.ConnectionString;
                string query = "SELECT coursetable.coursename FROM coursetable";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbCommand command = new OleDbCommand(query, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string menuItemName = reader.GetString(0);
                        ToolStripMenuItem menuItem = new ToolStripMenuItem(menuItemName);
                        menuItem.Click += MenuItem_Click;
                        MenuItem.Items.Add(menuItem);
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while populating menu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
                string degreename = clickedItem.Text;
                displaystudentdata(degreename);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while processing menu item click: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void displaystudentdata(string degreename)
        {
            try
            {
                int yoffset = 55;
                int height = 45;
                StIDPanel.Controls.Clear();
                StNaPanel.Controls.Clear();
                CoIDPanel.Controls.Clear();
                CoNaPanel.Controls.Clear();
                GPAPanel.Controls.Clear();

                string connectionstr = dbconnection.Instance.ConnectionString;
                using (OleDbConnection conn = new OleDbConnection(connectionstr))
                {
                    string sql = "SELECT student.StudentID, student.StudentName, coursetable.courseid, coursetable.coursename, studentgpa.StudentGPA " +
                        "FROM (coursetable INNER JOIN student ON coursetable.courseid = student.courseid) INNER JOIN studentgpa ON student.StudentID = studentgpa.StudentID " +
                        "WHERE (((coursetable.coursename)=@degreename));";
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@degreename", degreename);
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string studentid = reader.GetString(0);
                                string studentname = reader.GetString(1);
                                string courseid = reader.GetString(2);
                                string coursename = reader.GetString(3);
                                double stdgpa = reader.GetDouble(4);

                                Label studentidlabel = new Label();
                                studentidlabel.Text = studentid;
                                studentidlabel.AutoSize = false;
                                studentidlabel.Width = StIDPanel.Width;
                                studentidlabel.Height = height;
                                studentidlabel.Font = new Font("Microsoft Sans Serif", 18);
                                studentidlabel.ForeColor = Color.White;
                                studentidlabel.TextAlign = ContentAlignment.MiddleCenter;
                                studentidlabel.Location = new Point(0, yoffset);
                                StIDPanel.Controls.Add(studentidlabel);

                                Label studentnamelabel = new Label();
                                studentnamelabel.Text = studentname;
                                studentnamelabel.AutoSize = false;
                                studentnamelabel.Width = StNaPanel.Width;
                                studentnamelabel.Height = height;
                                studentnamelabel.Font = new Font("Microsoft Sans Serif", 18);
                                studentnamelabel.ForeColor = Color.White;
                                studentnamelabel.TextAlign = ContentAlignment.MiddleCenter;
                                studentnamelabel.Location = new Point(0, yoffset);
                                StNaPanel.Controls.Add(studentnamelabel);

                                Label stdcourseid = new Label();
                                stdcourseid.Text = courseid;
                                stdcourseid.AutoSize = false;
                                stdcourseid.Width = CoIDPanel.Width;
                                stdcourseid.Height = height;
                                stdcourseid.Font = new Font("Microsoft Sans Serif", 18);
                                stdcourseid.ForeColor = Color.White;
                                stdcourseid.TextAlign = ContentAlignment.MiddleCenter;
                                stdcourseid.Location = new Point(0, yoffset);
                                CoIDPanel.Controls.Add(stdcourseid);

                                Label stdcoursename = new Label();
                                stdcoursename.Text = coursename;
                                stdcoursename.AutoSize = false;
                                stdcoursename.Width = CoNaPanel.Width;
                                stdcoursename.Height = height;
                                stdcoursename.Font = new Font("Microsoft Sans Serif", 18);
                                stdcoursename.ForeColor = Color.White;
                                stdcoursename.TextAlign = ContentAlignment.MiddleCenter;
                                stdcoursename.Location = new Point(0, yoffset);
                                CoNaPanel.Controls.Add(stdcoursename);

                                Label stdgpalabel = new Label();
                                stdgpalabel.Text = Convert.ToString(stdgpa);
                                stdgpalabel.AutoSize = false;
                                stdgpalabel.Width = GPAPanel.Width;
                                stdgpalabel.Height = height;
                                stdgpalabel.Font = new Font("Microsoft Sans Serif", 18);
                                stdgpalabel.ForeColor = Color.White;
                                stdgpalabel.TextAlign = ContentAlignment.MiddleCenter;
                                stdgpalabel.Location = new Point(0, yoffset);
                                GPAPanel.Controls.Add(stdgpalabel);

                                yoffset += 40;
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while displaying student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void rjbtnSearch_Click(object sender, EventArgs e)
        {
            student_det_viewform viewform = new student_det_viewform();
            viewform.Show();
        }

    }
}
