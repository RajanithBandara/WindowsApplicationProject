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
    public partial class Progression_Dashboard : Form
    {
        public Progression_Dashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnGPA_Click(object sender, EventArgs e)
        {
            FormGPADistribution form2 = new FormGPADistribution();
            form2.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //For Overall GPA Chart
            chartOverallGPA.Series["SE"].Points.AddXY("A", 100);
            chartOverallGPA.Series["SE"].Points.AddXY("B", 70);
            chartOverallGPA.Series["SE"].Points.AddXY("C", 160);
            chartOverallGPA.Series["SE"].Points.AddXY("D", 50);
            chartOverallGPA.Series["SE"].Points.AddXY("E", 40);
            chartOverallGPA.Series["SE"].Points.AddXY("F", 30);

            chartOverallGPA.Series["CS"].Points.AddXY("A", 60);
            chartOverallGPA.Series["CS"].Points.AddXY("B", 74);
            chartOverallGPA.Series["CS"].Points.AddXY("C", 59);
            chartOverallGPA.Series["CS"].Points.AddXY("D", 20);
            chartOverallGPA.Series["CS"].Points.AddXY("E", 140);
            chartOverallGPA.Series["CS"].Points.AddXY("F", 36);

            chartOverallGPA.Series["DS"].Points.AddXY("A", 80);
            chartOverallGPA.Series["DS"].Points.AddXY("B", 70);
            chartOverallGPA.Series["DS"].Points.AddXY("C", 60);
            chartOverallGPA.Series["DS"].Points.AddXY("D", 50);
            chartOverallGPA.Series["DS"].Points.AddXY("E", 40);
            chartOverallGPA.Series["DS"].Points.AddXY("F", 30);

            chartOverallGPA.Series["CN"].Points.AddXY("A", 106);
            chartOverallGPA.Series["CN"].Points.AddXY("B", 96);
            chartOverallGPA.Series["CN"].Points.AddXY("C", 45);
            chartOverallGPA.Series["CN"].Points.AddXY("D", 25);
            chartOverallGPA.Series["CN"].Points.AddXY("E", 40);
            chartOverallGPA.Series["CN"].Points.AddXY("F", 30);

            chartOverallGPA.Series["IMS"].Points.AddXY("A", 125);
            chartOverallGPA.Series["IMS"].Points.AddXY("B", 69);
            chartOverallGPA.Series["IMS"].Points.AddXY("C", 60);
            chartOverallGPA.Series["IMS"].Points.AddXY("D", 145);
            chartOverallGPA.Series["IMS"].Points.AddXY("E", 32);
            chartOverallGPA.Series["IMS"].Points.AddXY("F", 25);





            // For Overall Course Progression 
            chartOverallCourse.Series["SE"].Points.AddXY("1st Year 1st Sem", 20);
            chartOverallCourse.Series["SE"].Points.AddXY("1st Year 2nd Sem", 30);
            chartOverallCourse.Series["SE"].Points.AddXY("2nd Year 1st Sem", 40);
            chartOverallCourse.Series["SE"].Points.AddXY("2nd Year 2nd Sem", 50);
            chartOverallCourse.Series["SE"].Points.AddXY("3rd Year 1st Sem", 60);
            chartOverallCourse.Series["SE"].Points.AddXY("3rd Year 2nd Sem", 70);

            chartOverallCourse.Series["CS"].Points.AddXY("1st Year 1st Sem", 70);
            chartOverallCourse.Series["CS"].Points.AddXY("1st Year 2nd Sem", 60);
            chartOverallCourse.Series["CS"].Points.AddXY("2nd Year 1st Sem", 50);
            chartOverallCourse.Series["CS"].Points.AddXY("2nd Year 2nd Sem", 40);
            chartOverallCourse.Series["CS"].Points.AddXY("3rd Year 1st Sem", 30);
            chartOverallCourse.Series["CS"].Points.AddXY("3rd Year 2nd Sem", 20);

            chartOverallCourse.Series["DS"].Points.AddXY("1st Year 1st Sem", 50);
            chartOverallCourse.Series["DS"].Points.AddXY("1st Year 2nd Sem", 40);
            chartOverallCourse.Series["DS"].Points.AddXY("2nd Year 1st Sem", 30);
            chartOverallCourse.Series["DS"].Points.AddXY("2nd Year 2nd Sem", 20);
            chartOverallCourse.Series["DS"].Points.AddXY("3rd Year 1st Sem", 10);
            chartOverallCourse.Series["DS"].Points.AddXY("3rd Year 2nd Sem", 5);

            chartOverallCourse.Series["CN"].Points.AddXY("1st Year 1st Sem", 80);
            chartOverallCourse.Series["CN"].Points.AddXY("1st Year 2nd Sem", 70);
            chartOverallCourse.Series["CN"].Points.AddXY("2nd Year 1st Sem", 60);
            chartOverallCourse.Series["CN"].Points.AddXY("2nd Year 2nd Sem", 50);
            chartOverallCourse.Series["CN"].Points.AddXY("3rd Year 1st Sem", 40);
            chartOverallCourse.Series["CN"].Points.AddXY("3rd Year 2nd Sem", 30);

            chartOverallCourse.Series["IMS"].Points.AddXY("1st Year 1st Sem", 90);
            chartOverallCourse.Series["IMS"].Points.AddXY("1st Year 2nd Sem", 80);
            chartOverallCourse.Series["IMS"].Points.AddXY("2nd Year 1st Sem", 70);
            chartOverallCourse.Series["IMS"].Points.AddXY("2nd Year 2nd Sem", 60);
            chartOverallCourse.Series["IMS"].Points.AddXY("3rd Year 1st Sem", 50);
            chartOverallCourse.Series["IMS"].Points.AddXY("3rd Year 2nd Sem", 40);


            //For Overall Student Progression Dashboard
            chartOverallStudentProgression.Series["SE"].Points.AddXY("1st Year 1st Sem", 20);
            chartOverallStudentProgression.Series["SE"].Points.AddXY("1st Year 2nd Sem", 30);
            chartOverallStudentProgression.Series["SE"].Points.AddXY("2nd Year 1st Sem", 40);
            chartOverallStudentProgression.Series["SE"].Points.AddXY("2nd Year 2nd Sem", 50);
            chartOverallStudentProgression.Series["SE"].Points.AddXY("3rd Year 1st Sem", 60);
            chartOverallStudentProgression.Series["SE"].Points.AddXY("3rd Year 2nd Sem", 70);

            chartOverallStudentProgression.Series["CS"].Points.AddXY("1st Year 1st Sem", 70);
            chartOverallStudentProgression.Series["CS"].Points.AddXY("1st Year 2nd Sem", 60);
            chartOverallStudentProgression.Series["CS"].Points.AddXY("2nd Year 1st Sem", 50);
            chartOverallStudentProgression.Series["CS"].Points.AddXY("2nd Year 2nd Sem", 40);
            chartOverallStudentProgression.Series["CS"].Points.AddXY("3rd Year 1st Sem", 30);
            chartOverallStudentProgression.Series["CS"].Points.AddXY("3rd Year 2nd Sem", 20);

            chartOverallStudentProgression.Series["DS"].Points.AddXY("1st Year 1st Sem", 50);
            chartOverallStudentProgression.Series["DS"].Points.AddXY("1st Year 2nd Sem", 40);
            chartOverallStudentProgression.Series["DS"].Points.AddXY("2nd Year 1st Sem", 30);
            chartOverallStudentProgression.Series["DS"].Points.AddXY("2nd Year 2nd Sem", 20);
            chartOverallStudentProgression.Series["DS"].Points.AddXY("3rd Year 1st Sem", 10);
            chartOverallStudentProgression.Series["DS"].Points.AddXY("3rd Year 2nd Sem", 5);

            chartOverallStudentProgression.Series["CN"].Points.AddXY("1st Year 1st Sem", 80);
            chartOverallStudentProgression.Series["CN"].Points.AddXY("1st Year 2nd Sem", 70);
            chartOverallStudentProgression.Series["CN"].Points.AddXY("2nd Year 1st Sem", 60);
            chartOverallStudentProgression.Series["CN"].Points.AddXY("2nd Year 2nd Sem", 50);
            chartOverallStudentProgression.Series["CN"].Points.AddXY("3rd Year 1st Sem", 40);
            chartOverallStudentProgression.Series["CN"].Points.AddXY("3rd Year 2nd Sem", 30);

            chartOverallStudentProgression.Series["IMS"].Points.AddXY("1st Year 1st Sem", 90);
            chartOverallStudentProgression.Series["IMS"].Points.AddXY("1st Year 2nd Sem", 80);
            chartOverallStudentProgression.Series["IMS"].Points.AddXY("2nd Year 1st Sem", 70);
            chartOverallStudentProgression.Series["IMS"].Points.AddXY("2nd Year 2nd Sem", 60);
            chartOverallStudentProgression.Series["IMS"].Points.AddXY("3rd Year 1st Sem", 50);
            chartOverallStudentProgression.Series["IMS"].Points.AddXY("3rd Year 2nd Sem", 40);


            //foe Overall Pass Fail Chart
            chartOverallPassFailPercentage.Series["Pass"].Points.AddXY("SE", 120);
            chartOverallPassFailPercentage.Series["Fail"].Points.AddXY("SE", 30);

            chartOverallPassFailPercentage.Series["Pass"].Points.AddXY("CS", 100);
            chartOverallPassFailPercentage.Series["Fail"].Points.AddXY("CS", 50);

            chartOverallPassFailPercentage.Series["Pass"].Points.AddXY("DS", 90);
            chartOverallPassFailPercentage.Series["Fail"].Points.AddXY("DS", 60);

            chartOverallPassFailPercentage.Series["Pass"].Points.AddXY("CN", 80);
            chartOverallPassFailPercentage.Series["Fail"].Points.AddXY("CN", 70);

            chartOverallPassFailPercentage.Series["Pass"].Points.AddXY("IMS", 70);
            chartOverallPassFailPercentage.Series["Fail"].Points.AddXY("IMS", 80);







        }

     

    }
}
