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

namespace WindowsAppProject
{
    public partial class maindashboard : Form
    {
        public maindashboard()
        {
            InitializeComponent();
        }

        private string connectstr = dbconnection.Instance.ConnectionString;

        private void showtopdetails()
        {

        }

        private void rjPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void maindashboard_Load(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            await Task.Run(() => displayusrctrl());

        }
        private void displayusrctrl()
        {
            student_top_view student_Top_View = new student_top_view();
            addusercontrol(student_Top_View);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            adminloginform adminlogin = new adminloginform();
            adminlogin.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            gpacalculator gpa_window = new gpacalculator();
            gpa_window.Show();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            std_dashboard std_Dashboard = new std_dashboard();
            std_Dashboard.Show();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            course_dashboard course_dash = new course_dashboard();
            course_dash.Show(); 
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            course_dashboard course_Dashboard = new course_dashboard();
            course_Dashboard.Show();
        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            gpacalculator gpacal = new gpacalculator();
            gpacal.Show();
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

        private void rjButton8_Click(object sender, EventArgs e)
        {
            gpacalculation();
            //Console.WriteLine("Hellow");
        }

        public class student
        {
            public string ID { get; set; }
            public string grade { get; set; }
            public int credits { get; set; }
            public float gpa { get; set; }
        }
        private void gpacalculation()
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

           
            int totalcredits = 0;

            float creditstogpa = 0;
            float gpaforgrade = 0;
            foreach (var studentEntry in studentlist)
            {
                string stdid = studentEntry.Key;
                List<student> studentdata = studentEntry.Value;
                

                foreach (var student in studentdata)
                {
                    totalcredits = totalcredits + student.credits;
                    string grade = student.grade;
                    switch (grade)
                    {
                        case "A":
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
            
        }
    }
}
