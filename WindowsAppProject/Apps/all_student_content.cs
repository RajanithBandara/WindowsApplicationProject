using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsAppProject.Apps
{
    public partial class all_student_content : Form
    {
        public all_student_content()
        {
            InitializeComponent();
            PopulateMenu();
        }

        private void PopulateMenu()
        {
            string connectionString = dbconnection.Instance.ConnectionString;
            string query = "SELECT coursetable.coursename FROM coursetable";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string menuItemName = reader.GetString(0);
                    ToolStripMenuItem menuItem = new ToolStripMenuItem(menuItemName);
                    menuItem.Click += MenuItem_Click;
                    MenuItem.Items.Add(menuItem);
                }
                reader.Close();
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            string menuItemName = clickedItem.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
