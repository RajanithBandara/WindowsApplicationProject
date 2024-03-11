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
    public partial class profile_page : Form
    {
        public profile_page()
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
            type_select degreereg_sec = new type_select();
            degreereg_sec.Show();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            course_dashboard corse_dash = new course_dashboard();   
            corse_dash.Show();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            maindashboard mainmenu = new maindashboard();   
            mainmenu.Show();

        }
    }
}
