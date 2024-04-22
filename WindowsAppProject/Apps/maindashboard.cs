using practice_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppProject.Apps;
using System.Data.OleDb;
using WindowsAppProject.Apps.usercontrol_maindashboard;
using static WindowsAppProject.maindashboard;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;

namespace WindowsAppProject
{
    public partial class maindashboard : Form
    {

        private Form[] otherdashes;

        public maindashboard()
        {
            InitializeComponent();
            //this.FormClosing += maindashboard_FormClosing;
        }
        private T FindOpenForm<T>() where T : Form
        {
            return Application.OpenForms.OfType<T>().FirstOrDefault();
        }

        private void maindashboard_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to close this form?", "Close Form", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void OpenChildForm<T>() where T : Form, new()
        {
            T form = FindOpenForm<T>();
            if (form == null)
            {
                form = new T();
                form.FormClosed += ChildForm_FormClosed;
                form.Show();
            }
            else
            {
                form.BringToFront();
            }
        }
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this form?", "Close Form", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ((Form)sender).FormClosed -= ChildForm_FormClosed;
            }
            else
            {
                this.Close();
            }
        }


        private string connectstr = dbconnection.Instance.ConnectionString;


        private void rjPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void maindashboard_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            await Task.Delay(1200);
            displayusrctrl();
            ardataload();
            
        }
        private void ardataload()
        {
            string arusername = session.Username;
            using (OleDbConnection conn = new OleDbConnection(connectstr))
            {
                string sqlcmd = "SELECT * FROM aruserdata WHERE username = @arusername";
                using (OleDbCommand cmd = new OleDbCommand(sqlcmd, conn))
                {
                    cmd.Parameters.AddWithValue("@arusername", arusername);
                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = session.Username;
                            textBox2.Text = reader["Fullname"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
        }
        private void rjButton_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void rjButton_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
        private void rjButton6_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void rjButton6_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void rjButton7_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
        }
        private void rjButton7_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void rjButton8_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
        }
        private void rjButton8_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private async void displayusrctrl()
        {
            await Task.Delay(100);
            student_top_view student_Top_View = new student_top_view();
            addusercontrol(student_Top_View);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm<adminloginform>();
        }
        private void rjButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm<gpacalculator>(); 
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm<all_student_content>();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm<course_dashboard>(); 
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm<course_dashboard>(); 
        }


        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm<gpacalculator>();
        }
        private void addusercontrol(UserControl usrctrl)
        {
            rjPanel3.Invoke((MethodInvoker)delegate {
                usrctrl.Dock = DockStyle.Fill;
                rjPanel3.Controls.Clear();
                rjPanel3.Controls.Add(usrctrl);
            });
        }

        private void rjButton5_Click_1(object sender, EventArgs e)
        {
            student_register_usrctrl std_reg = new student_register_usrctrl();
            addusercontrol(std_reg);
        }



        private void rjButton6_Click(object sender, EventArgs e)
        {
            student_top_view studenttop_usrctrl = new student_top_view();
            addusercontrol(studenttop_usrctrl);
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            student_markadd student_Markadd = new student_markadd();
            addusercontrol(student_Markadd);
        }

        private async void rjButton8_Click(object sender, EventArgs e)
        {
            maindash_loading maindash_Loading = new maindash_loading();
            rjButton8.Enabled = false;
            addusercontrol(maindash_Loading);
            await gpacalculation();
            rjButton8.Enabled = true;
            maindash_Loading.StopLoading();
            maindash_Loading.Visible = false;
            student_top_view student_top_view = new student_top_view();
            addusercontrol(student_top_view);
        }

        public class student
        {
            public string ID { get; set; }
            public string grade { get; set; }
            public int credits { get; set; }
            public float gpa { get; set; }
        }
        private async Task gpacalculation()
        {
            Dictionary<string, List<student>> studentlist = new Dictionary<string, List<student>>();
            using (OleDbConnection conn = new OleDbConnection(connectstr))
            {
                string sqlcmd = "Select StudentId,ModuleCredits,ModuleGrade from studentmoduleresult";
                using (OleDbCommand cmd = new OleDbCommand(sqlcmd, conn))
                {
                    try
                    {
                        conn.Open();
                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string stdid = reader.GetString(0);
                            int mdlcredits = reader.GetInt32(1);
                            string mdlgrade = reader.GetString(2);
                            if (!studentlist.ContainsKey(stdid))
                            {
                                studentlist[stdid] = new List<student>();   
                            }
                            studentlist[stdid].Add(new student { ID = stdid, credits = mdlcredits, grade = mdlgrade });
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error", ex.Message);
                    }
                }
            }

           
            
            foreach (var studentEntry in studentlist)
            {
                string stdid = studentEntry.Key;
                List<student> studentdata = studentEntry.Value;

                int totalcredits = 0;
                float creditstogpa = 0;
                float gpaforgrade = 0;
                foreach (var student in studentdata)
                {
                    totalcredits = totalcredits + student.credits;
                    string grade = student.grade;
                    switch (grade)
                    {
                        case "A":
                            gpaforgrade = 4.00f;
                            break;
                        case "A+":
                            gpaforgrade = 4.00f;
                            break;
                        case "A-":
                            gpaforgrade = 3.70f;
                            break;
                        case "B+":
                            gpaforgrade = 3.30f;
                            break;
                        case "B":
                            gpaforgrade = 3.00f;
                            break;
                        case "B-":
                            gpaforgrade = 2.70f;
                            break;
                        case "C+":
                            gpaforgrade = 2.30f;
                            break;
                        case "C":
                            gpaforgrade = 2.00f;
                            break; 
                        case "C-":
                            gpaforgrade = 1.70f;
                            break;
                        case "D+":
                            gpaforgrade = 1.30f;
                            break;
                        case "D":
                            gpaforgrade = 1.00f;
                            break;
                        case "D-":
                            gpaforgrade = 0.70f;
                            break;
                        case "F":
                            gpaforgrade = 0.00f;
                            break;
                        default:
                            gpaforgrade = 0.00f;
                            break;
                    }
                    float temp = gpaforgrade * student.credits;
                    creditstogpa = creditstogpa + temp;
                }
                float finalresult = creditstogpa / totalcredits;

                string sqlcmd3 = $"UPDATE studentgpa SET StudentGPA = @finalresult WHERE studentid = @stdid";

                using (OleDbConnection conn = new OleDbConnection(connectstr))
                {
                    conn.Open();
                    using (OleDbCommand cmdrun = new OleDbCommand(sqlcmd3, conn))
                    {
                        cmdrun.Parameters.AddWithValue("@finalresult", finalresult);
                        cmdrun.Parameters.AddWithValue("@stdid", stdid);
                        int rowsAffected = cmdrun.ExecuteNonQuery();

                        
                        
                    }
                    conn.Close();
                }
            }
            await Task.Delay(3000);
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentIdGetter.StudentId = "";
                arloginform arloginform = new arloginform();
                arloginform.Show();
                this.Hide();
            }
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            student_remove student_remov = new student_remove();
            addusercontrol(student_remov);
        }

        private void rjButton9_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void rjButton9_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void rjButton10_Click(object sender, EventArgs e)
        {
            ExportToCSV();
        }

        private void ExportToCSV()
        {
            string connectionString = dbconnection.Instance.ConnectionString;
            DataSet dataSet = new DataSet();
            string[] tableNames = { "courseTable", "student", "studentgpa", "studentmoduleresult" };

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                foreach (string tableName in tableNames)
                {
                    string query = $"SELECT * FROM {tableName}";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                        adapter.Fill(dataSet, tableName);
                    }
                }
                connection.Close();
            }

            string selectedFilePath = "";
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.Title = "Save CSV File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = saveFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Invalid file selection.");
                    return;
                }
            }

            foreach (DataTable dataTable in dataSet.Tables)
            {
                string fileName = $"{dataTable.TableName}.csv";
                SaveDataTableToCSV(dataTable, selectedFilePath);
            }

            MessageBox.Show("Data exported to CSV successfully!");
        }

        private void SaveDataTableToCSV(DataTable dataTable, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    writer.Write(column.ColumnName + ",");
                }
                writer.WriteLine();

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        writer.Write(item.ToString() + ",");
                    }
                    writer.WriteLine();
                }

                writer.WriteLine();

                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    writer.Write("----,");

                    if (i == dataTable.Columns.Count - 1)
                        writer.WriteLine();
                }
            }
        }

        private void rjButton10_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void rjButton10_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }
    }
}
