using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

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
            NpgsqlConnection conn = new NpgsqlConnection(connectionstr);
            conn.Open();
            string sqlline1 = "SELECT username FROM public.aruserdata";
            using (NpgsqlCommand cmd = new NpgsqlCommand(sqlline1, conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
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
                        lbl.Width = 100;
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
