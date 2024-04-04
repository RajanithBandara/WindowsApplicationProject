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

        }
    }
}
