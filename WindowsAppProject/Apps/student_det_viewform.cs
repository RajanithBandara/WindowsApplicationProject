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
    public partial class student_det_viewform : Form
    {
        public student_det_viewform()
        {
            InitializeComponent();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void rjPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
