using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppProject.Apps.usercontrol_studentdash
{
    public partial class remove_module : Form
    {
        public remove_module()
        {
            InitializeComponent();
        }
        private void removemodule()
        {
            string module_code = textBox1.Text;
            string module_name = textBox2.Text;
            int semester_no = Convert.ToInt32(textBox3.Text);

            string connstr = dbconnection.Instance.ConnectionString;

            using (OleDbConnection conn = new OleDbConnection(connstr))
            {
                conn.Open();
                string sql = "DELETE FROM studentmoduleresult WHERE StudentID = @studentid AND ModuleCode = @modulecode AND ModuleName = @modulename AND Semester = @semester";
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@studentid", StudentIdGetter.StudentId);
                    cmd.Parameters.AddWithValue("@modulecode", module_code);
                    cmd.Parameters.AddWithValue("@modulename", module_name);
                    cmd.Parameters.AddWithValue("@semester", semester_no);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Module removed successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Module not found or couldn't be removed.");
                    }
                }
            }
        }



        private void rjButton2_Click(object sender, EventArgs e)
        {
            removemodule();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
