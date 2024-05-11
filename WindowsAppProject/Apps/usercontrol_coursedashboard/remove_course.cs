using practice_project;
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
    public partial class remove_course : UserControl
    {
        public remove_course()
        {
            InitializeComponent();
        }
        private string connectionstr = dbconnection.Instance.ConnectionString;
        private void addusercontrol(UserControl uc)
        {
        }   
        private void rjButton1_Click(object sender, EventArgs e)
        {
            string courseid = textBox1.Text;
            using (OleDbConnection conn = new OleDbConnection(connectionstr))
            {
                try
                {
                    conn.Open();
                    string sqlcmd = "DELETE FROM coursetable WHERE courseid = @courseid";
                    using (OleDbCommand cmd = new OleDbCommand(sqlcmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@courseid", courseid);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Course Removed Successfully");
                        }
                        else
                        {
                            MessageBox.Show($"No course found with the provided ID = {courseid}.");
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    conn.Close(); 
                }
            }


        }

        private void remove_course_Load(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
    }
}
