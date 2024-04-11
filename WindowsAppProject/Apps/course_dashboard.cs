using RoundedPanelClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            remove_course removecourse = new remove_course();
            addusercontrol(removecourse);
        }

        private void rjButton1_mousehover(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void rjButton1_mouseleave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void rjButton2_mousehover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void rjButton2_mouseleave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void rjButton3_mousehover(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void rjButton3_mouseleave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }
    }
}
