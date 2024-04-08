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

        // Add data base.
        private string connectionString = "YourConnectionString";
        private SqlConnection connection;

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

        private void rjPStDeView_Paint(object sender, PaintEventArgs e)// Panel 2 changes
        {

        }

        private void txtStDVStName_TextChanged(object sender, EventArgs e)//show st name txt
        {

        }

        private void txtStDVShStID_TextChanged(object sender, EventArgs e)// show st id txt
        {

        }

        private void txtSTDVCoName_TextChanged(object sender, EventArgs e)//show course txt
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//show st gpa txt
        {

        }

        private void rjButGoBack_Click(object sender, EventArgs e)// go back button
        {
            all_student_content all_Student_Content = new all_student_content();
            all_Student_Content.Show();
        }


    }
}
