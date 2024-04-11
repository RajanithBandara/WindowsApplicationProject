using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppProject.Apps.usercontrol_studentdash;

namespace WindowsAppProject.Apps
{
    public partial class std_dashboard : Form
    {
        public std_dashboard()
        {
            InitializeComponent();
        }
        private void addusercontrol(UserControl usrctrl)
        {
            usrctrl.Dock = DockStyle.Fill;
            mainpanelstd.Controls.Clear();
            mainpanelstd.Controls.Add(usrctrl);
        }
        private void mainpanelstd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            module_view module_view = new module_view();
            addusercontrol(module_view);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            testchart chartview = new testchart();
            addusercontrol(chartview);
        }

        private void std_dashboard_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
        }

        private void rjButton1_mousehover(object sender, EventArgs e)
        {
            label1.Visible=true;
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
    }
}
