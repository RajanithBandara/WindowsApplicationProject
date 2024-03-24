using RoundedPanelClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsAppProject;
using WindowsAppProject.Apps.usercontrol_coursedashboard;

namespace practice_project
{
    public partial class course_dashboard : Form
    {
        public course_dashboard()
        {
            InitializeComponent();
        }
        private static int sum = 0;
        private static int x = 0;
        



        private void Mgrade_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        
        private void RemoveModuleControl()
        {
            
        }

        private void MName_Paint(object sender, PaintEventArgs e)
        {

        }

      

        
      

        private void textbxpanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void addusercontrol(UserControl usrctrl)
        {
            usrctrl.Dock = DockStyle.Fill;
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(usrctrl);

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            courses_view corsesview = new courses_view();
            addusercontrol(corsesview);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            reg_course registercourse = new reg_course();
            addusercontrol(registercourse);
        }

        private void contentpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void course_dashboard_Load(object sender, EventArgs e)
        {
            courses_view corsesview = new courses_view();
            addusercontrol(corsesview);
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            remove_course removecourse = new remove_course();
            addusercontrol(removecourse);
        }
    }
}
