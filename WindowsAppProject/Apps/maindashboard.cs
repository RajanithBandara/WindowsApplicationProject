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

namespace WindowsAppProject
{
    public partial class maindashboard : Form
    {
        public maindashboard()
        {
            InitializeComponent();
        }

        private void rjPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maindashboard_Load(object sender, EventArgs e)
        {

        }
        private void maindashboard_Resize(object sender, EventArgs e)
        {
            
        }

        private void rjPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            admin_panel adminpanel = new admin_panel();
            adminpanel.Show();
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
            student_dashboard student_Dashboard = new student_dashboard();
            student_Dashboard.Show();
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

        private void rjPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            gpacalculator gpacal = new gpacalculator();
            gpacal.Show();
        }
    }
}
