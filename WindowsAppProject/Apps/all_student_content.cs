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
            BackPanel.AutoScroll = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblStName_Click(object sender, EventArgs e)
        {

        }

        private void lblCoID_Click(object sender, EventArgs e)
        {

        }

        private void rjbtnSearch_Click(object sender, EventArgs e)
        {
            student_det_viewform student_Det_Viewform = new student_det_viewform();
            student_Det_Viewform.Show();
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
                StIDPanel.Controls.Add(idLabel);

                Label nameLabel = new Label();
                nameLabel.Text = "Name: " + studentNames[i];
                StNaPanel.Controls.Add(nameLabel);

                Label degreeLabel = new Label();
                degreeLabel.Text = "Degree ID: " + degreeIds[i];
                CoIDPanel.Controls.Add(degreeLabel);

                Label courseLabel = new Label();
                courseLabel.Text = "Course: " + courseNames[i];
                CoNaPanel.Controls.Add(courseLabel);

                Label gpaLabel = new Label();
                gpaLabel.Text = "GPA: " + gpas[i].ToString();
                GPAPanel.Controls.Add(gpaLabel);
            }
        }

    }
}
