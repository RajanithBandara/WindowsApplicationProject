﻿using System;
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
    public partial class all_student_content : Form
    {
        public all_student_content()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rjPStID_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblStName_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButtSearch_Click(object sender, EventArgs e)
        {
            student_det_viewform student_Det_Viewform = new student_det_viewform();
            student_Det_Viewform.Show();
        }

        private void rjPDescription_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
