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

        private void maindashboard_Load(object sender, EventArgs e)
        {
            student_top_view student_Top_View = new student_top_view();
            addusercontrol(student_Top_View);
        }
        private void maindashboard_Resize(object sender, EventArgs e)
        {
            
        }

        private void rjPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            adminloginform adminlogin = new adminloginform();
            adminlogin.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
            usrctrl.Dock = DockStyle.Fill;
            rjPanel3.Controls.Clear();
            rjPanel3.Controls.Add(usrctrl);

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
    }
}
