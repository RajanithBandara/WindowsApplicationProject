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
    public partial class all_student_content : Form
    {
        public all_student_content()
        {
            InitializeComponent();
            PPanel.AutoScroll = true;
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

        private void all_student_content_Load(object sender, EventArgs e)
        {
            LoadStudentDetails();
        }

        private void LoadStudentDetails()
        {
            string[] studentIds = { "1001", "1002", "1003", "1004", "1005" };
            string[] studentNames = { "John", "Alice", "Bob", "Emily", "David" };
            string[] degreeIds = { "D1001", "D1002", "D1003", "D1004", "D1005" };
            string[] courseNames = { "Math", "Physics", "Chemistry", "Biology", "Computer Science" };
            double[] gpas = { 3.5, 3.8, 3.2, 3.9, 3.7 };

            // Add student details to each panel
            for (int i = 0; i < studentIds.Length; i++)
            {
                Label idLabel = new Label();
                idLabel.Text = "ID: " + studentIds[i];
                PStID.Controls.Add(idLabel);

                Label nameLabel = new Label();
                nameLabel.Text = "Name: " + studentNames[i];
                PStName.Controls.Add(nameLabel);

                Label degreeLabel = new Label();
                degreeLabel.Text = "Degree ID: " + degreeIds[i];
                PDegID.Controls.Add(degreeLabel);

                Label courseLabel = new Label();
                courseLabel.Text = "Course: " + courseNames[i];
                PCoName.Controls.Add(courseLabel);

                Label gpaLabel = new Label();
                gpaLabel.Text = "GPA: " + gpas[i].ToString();
                PGPA.Controls.Add(gpaLabel);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
