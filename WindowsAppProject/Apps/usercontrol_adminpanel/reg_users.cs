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

namespace WindowsAppProject.Apps.usercontrol_adminpanel
{
    public partial class reg_users : UserControl
    {
        public reg_users()
        {
            InitializeComponent();
            
        }

        private string connectionstr = dbconnection.Instance.ConnectionString;

        public void display_cont()
        {
            int y = 0; 
            OleDbConnection conn = new OleDbConnection(connectionstr);
            conn.Open();
            string sqlline1 = "SELECT username FROM aruserdata";
            using (OleDbCommand cmd = new OleDbCommand(sqlline1, conn))
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        string username = reader["username"].ToString();
                        Label lbl = new Label(); 
                        lbl.ForeColor = Color.Black;
                        lbl.Location = new Point(40, 40 + y);
                        lbl.BackColor = Color.Transparent;
                        lbl.Text = username;
                        lbl.AutoSize = false;
                        lbl.Height = 50;
                        lbl.Width = 300;
                        lbl.Font = new Font("Microsoft Sans Serif",18);
                        rjPanel1.Controls.Add(lbl);
                        y += 50;
                    }
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("No records found.");
                    }
                }
            }
            conn.Close();

        }
        private void rjPanel1_Paint(object sender, PaintEventArgs e)
        {
            display_cont();
        }
    }
}
