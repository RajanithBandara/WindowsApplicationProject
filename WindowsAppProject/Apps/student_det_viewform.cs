using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppProject.Apps
{
    public partial class student_det_viewform : Form
    {
        public student_det_viewform()
        {
            InitializeComponent();
        }

        private void student_det_viewform_Load(object sender, EventArgs e) // on form load
        {

        }

        private void txtStDVEnStID_TextChanged(object sender, EventArgs e)//Enter st id txt

        {

        }

        private void rjButClear_Click(object sender, EventArgs e)// clear button
        {
            txtStDVEnStID.Text = string.Empty;
        }
        private void rjButSearch_Click(object sender, EventArgs e)// search button
        {

        }

        private void rjpSearch_Paint(object sender, PaintEventArgs e) // Panel 1 chnages
        {

        }

    }
}
