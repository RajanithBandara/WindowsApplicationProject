using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppProject.Apps.usercontrol_adminpanel;

namespace WindowsAppProject.Apps
{
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }
        private void addusercontrol(UserControl usrctrl)
        {
            usrctrl.Dock = DockStyle.Fill;
            admincontentpanel.Controls.Clear();
            admincontentpanel.Controls.Add(usrctrl);

        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            reg_users reg_Users = new reg_users();
            addusercontrol(reg_Users);
        }

        private void admin_panel_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            ar_reg ar_Reg = new ar_reg();
            addusercontrol(ar_Reg);
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
            label2.Visible =true;
        }

        private void rjButton2_mouseleave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
    }
}
