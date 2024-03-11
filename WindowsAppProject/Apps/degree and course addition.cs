using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppProject.Apps;
using Npgsql;

namespace WindowsAppProject
{
    public partial class type_select : Form
    {
        public type_select()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            string connectionstr = dbconnection.Instance.ConnectionString;
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionstr))
            {
                conn.Open();

                String coursetype = textBox1.Text;
                String coursename = textBox2.Text;
                String credits = textBox3.Text;
                //String courseid = textBox4.Text;

                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO public.degreeandcourse (degreename, course, gpa) VALUES (@degreename, @course, @gpa)", conn);
                cmd.Parameters.AddWithValue("@degreename", coursename);
                cmd.Parameters.AddWithValue("@course", coursename);
                cmd.Parameters.AddWithValue("@gpa", credits);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Degree and course added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
