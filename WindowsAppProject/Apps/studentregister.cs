using Npgsql;
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
    public partial class studentregister : Form
    {
        public studentregister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentregister_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string studentid = textBox1.Text;
            string studentname = textBox2.Text;
            string studentcourse = textBox3.Text;

            string connectstr = dbconnection.Instance.ConnectionString;
            using(NpgsqlConnection conn = new NpgsqlConnection(connectstr))
            {
                conn.Open();
                string sql = "INSERT INTO public.student VALUES(@StudentID, @StudentName, @courseid)";
                string sql2 = "Select * from public.coursetable where courseid = ";
                using(NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("StudentID", studentid);
                    cmd.Parameters.AddWithValue("StudentName", studentname);
                    cmd.Parameters.AddWithValue("courseid", studentcourse);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Registered Successfully");
                }
                conn.Close();
            }
        }
    }
}
