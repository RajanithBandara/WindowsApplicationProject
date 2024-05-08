using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsAppProject.Apps.usercontrol_coursedashboard
{
    public partial class reg_course : UserControl
    {
        public reg_course()
        {
            InitializeComponent();
        }

        public string connectstr = dbconnection.Instance.ConnectionString;
        private void rjButton1_Click(object sender, EventArgs e)
        {
            senddatafunction(); 

        }
        private void senddatafunction()
        {
            string course_id = textBox1.Text;
            string course_name = textBox2.Text;
            string course_credits = textBox3.Text;
            string course_type = "";
            int.TryParse(course_credits, out int credits); 

            if (radioButton1.Checked)
            {
                course_type = "Degree";
            }
            else if (radioButton2.Checked)
            {
                course_type = "Diploma";
            }
            else
            {
                MessageBox.Show("Please select course type.");
                return; 
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectstr))
                {
                    string sql = "INSERT INTO coursetable VALUES(@course_id, @course_name, @course_credits, @course_type)";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@course_id", course_id);
                        cmd.Parameters.AddWithValue("@course_name", course_name);
                        cmd.Parameters.AddWithValue("@course_credits", credits);
                        cmd.Parameters.AddWithValue("@course_type", course_type);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Course registered successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while registering the course: " + ex.Message);
            }

        }
    }
}
