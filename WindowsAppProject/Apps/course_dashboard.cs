using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsAppProject;

namespace practice_project
{
    public partial class course_dashboard : Form
    {
        public course_dashboard()
        {
            InitializeComponent();
        }
        private static int sum = 0;
        private static int x = 0;
        
        private void gpacalculator_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mgrade_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void AddModuleControl()
        {
            sum = 0;
            x = x + 46;
            TextBox newtextbx = new TextBox();
            TextBox newtextbx2 = new TextBox();
            TextBox newtextbx3 = new TextBox();

            newtextbx.Width = 530;
            newtextbx.TextAlign = HorizontalAlignment.Center;
            newtextbx.Height = 48;
            newtextbx.Font = new Font("Microsoft Sans Serif", 18);
            newtextbx.ScrollBars = ScrollBars.Both;
            newtextbx.Location = new Point(0, 0 + x);
            newtextbx.BorderStyle = BorderStyle.None;
            newtextbx.BackColor = SystemColors.ControlDarkDark;
            newtextbx.ForeColor = SystemColors.ControlLightLight;
            newtextbx.Margin = new Padding(3, 3, 3, 3);
            newtextbx.Name = "Module Name";

            newtextbx3.Width = 143;
            newtextbx3.Height = 48;
            newtextbx3.TextAlign = HorizontalAlignment.Center;
            newtextbx3.Font = new Font("Microsoft Sans Serif", 18);
            newtextbx3.Location = new Point(0, 0 + x);
            newtextbx3.BorderStyle = BorderStyle.None;
            newtextbx3.BackColor = SystemColors.ControlDarkDark;
            newtextbx3.ForeColor = SystemColors.ControlLightLight;
            newtextbx3.Margin = new Padding(3, 3, 3, 3);
            newtextbx3.Name = "Grade";

            newtextbx2.Width = 173;
            newtextbx2.TextAlign = HorizontalAlignment.Center;
            newtextbx2.Height = 48;
            newtextbx2.Font = new Font("Microsoft Sans Serif", 18);
            newtextbx2.Location = new Point(0, 0 + x);
            newtextbx2.BorderStyle = BorderStyle.None;
            newtextbx2.BackColor = SystemColors.ControlDarkDark;
            newtextbx2.ForeColor = SystemColors.ControlLightLight;
            newtextbx2.Margin = new Padding(3, 3, 3, 3);
            newtextbx2.Name = "Credits";

            
        }
        private void RemoveModuleControl()
        {
            
        }

        private void MName_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private float GetGradePoint(string grade)
        {
            switch (grade.ToUpper())
            {
                case "A":
                case "A+":
                    return 4.0f;
                case "A-":
                    return 3.7f;
                case "B+":
                    return 3.3f;
                case "B":
                    return 3.0f;
                case "B-":
                    return 2.7f;
                case "C+":
                    return 2.3f;
                case "C":
                    return 2.0f;
                case "C-":
                    return 1.7f;
                case "D+":
                    return 1.3f;
                case "D":
                    return 1.0f;
                case "D-":
                    return 0.7f;
                case "F":
                    return 0.0f;
                default:
                    return -1; 
            }
        }
      

        private void textbxpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            degree_and_course_addition coursereg = new degree_and_course_addition();
            coursereg.Show();
        }
    }
}
