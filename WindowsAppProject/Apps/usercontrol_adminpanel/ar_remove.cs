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

namespace WindowsAppProject.Apps.usercontrol_adminpanel
{
    public partial class ar_remove : UserControl
    {
        public ar_remove()
        {
            InitializeComponent();
        }

        private void ar_remove_Load(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            string connectionstr = dbconnection.Instance.ConnectionString;
            using (OleDbConnection odbccon = new OleDbConnection(connectionstr))
            {
                odbccon.Open();
                string sql = "delete from aruserdata where username = @username";
                string username = textBox1.Text;
                DialogResult result = MessageBox.Show($"Are you sure to delete all the data of {username}", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, odbccon))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Data deleted successfully");
                }
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
