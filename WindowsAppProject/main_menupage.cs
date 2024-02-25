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

namespace WindowsAppProject
{
    public partial class main_menupage : Form
    {
        public main_menupage()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            gpacalculator gpawindows = new gpacalculator();
            gpawindows.Show();
        }

        private void main_menupage_Load(object sender, EventArgs e)
        {
            
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            degree_and_course_addition degreereg_sec = new degree_and_course_addition();
            degreereg_sec.Show();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            course_dashboard corse_dash = new course_dashboard();   
            corse_dash.Show();
        }
    }
}
