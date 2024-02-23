using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppProject
{
    public partial class gpacalculator : Form
    {
        public gpacalculator()
        {
            InitializeComponent();
        }
        private static int x = 0;
        private static string[] credits_array = new string[100];
        private static string[] grades_array = new string[100];
        private static int n, m = 0;
        private static int sum = 0;
        private static string grade;
        private static float final_gpa_credits;
        private static float final_gpa;

        private void rjButton1_Click(object sender, EventArgs e)
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

            MName.Controls.Add(newtextbx);
            Mgrade.Controls.Add(newtextbx3);
            Mcredits.Controls.Add(newtextbx2);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

            if (MName.Controls.Count < 1)
            {
                return;
            }
            sum = 0;
            x = x - 46;

            MName.Controls.RemoveAt(MName.Controls.Count - 1);
            Mgrade.Controls.RemoveAt(Mgrade.Controls.Count - 1);
            Mcredits.Controls.RemoveAt(Mcredits.Controls.Count - 1);
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            foreach (Control control in Mcredits.Controls)
            {
                credits_array[n] = control.Text;
                n = n + 1;
            }
            if (credits_array is null)
            {
                foreach (Control control in Mcredits.Controls)
                {
                    credits_array[n] = control.Text;
                    n = n + 1;
                }
            }
            foreach (Control control in Mgrade.Controls)
            {
                grades_array[m] = control.Text;
                m = m + 1;
            }
            for (int i = 0; i < m; i++)
            {
                if (grades_array[i] == "A" || grades_array[i] == "A+")
                {
                    grade = "4.00";
                }
                else if (grades_array[i] == "A-")
                {
                    grade = "3.7";
                }
                else if (grades_array[i] == "B+")
                {
                    grade = "3.3";
                }
                else if (grades_array[i] == "B")
                {
                    grade = "3.00";
                }
                else if (grades_array[i] == "B-")
                {
                    grade = "2.7";
                }
                else if (grades_array[i] == "C+")
                {
                    grade = "2.3";
                }
                else if (grades_array[i] == "C")
                {
                    grade = "2.00";
                }
                else if (grades_array[i] == "C-")
                {
                    grade = "1.7";
                }
                else if (grades_array[i] == "D+")
                {
                    grade = "1.3";
                }
                else if (grades_array[i] == "D")
                {
                    grade = "1.00";
                }
                else if (grades_array[i] == "D-")
                {
                    grade = "0.7";
                }
                else if (grades_array[i] == "F")
                {
                    grade = "0.00";
                }
                final_gpa_credits = final_gpa_credits + (float.Parse(grade) * float.Parse(credits_array[i]));
            }
            for (int i = 0; i < n; i++)
            {
                sum = sum + Convert.ToInt32(credits_array[i]);
                credits_array[i] = null;
                grades_array[i] = null;
            }
            final_gpa = final_gpa_credits / sum;
            textBox1.Text = Convert.ToString(final_gpa);
            sum = 0;
            n = 0;
            m = 0;
            final_gpa_credits = 0;
            final_gpa = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
