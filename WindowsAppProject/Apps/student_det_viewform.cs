using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.KeyPreview = true;
            this.KeyPress += task_enter;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void task_enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjButton1_Click(sender, e);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            StudentIdGetter.StudentId = textBox1.Text;
            this.Hide();
            std_dashboard std_dashboard = new std_dashboard();
            std_dashboard.Show();
        }
    }
}
