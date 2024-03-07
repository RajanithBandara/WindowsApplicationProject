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

namespace WindowsAppProject
{
    public partial class Modules_Addition : Form
    {
        public Modules_Addition()
        {
            InitializeComponent();
        }

        private string connectionstr = "Host=165.232.167.179;Port=5432;Username=postgres;Password=rajanith2003;Database=usersdb";

        private void rjButton2_Click(object sender, EventArgs e)
        {
            string stdid = textBox1.Text;
            string modlecode = textBox2.Text;
            string modlename = textBox3.Text;

            if (!int.TryParse(textBox4.Text, out int semesterValue) || !int.TryParse(textBox5.Text, out int modlecreditsValue))
            {
                MessageBox.Show("Invalid numeric values for semester or module credits.");
                return;
            }

            string modlegrades = textBox6.Text;

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionstr))
                {
                    conn.Open();

                    string sqlQuery = "INSERT INTO public.studentmoduleresult VALUES (@stdid, @modlecode, @modlename, @semester, @modlecredits, @modlegrades)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@stdid", stdid);
                        cmd.Parameters.AddWithValue("@modlecode", modlecode);
                        cmd.Parameters.AddWithValue("@modlename", modlename);
                        cmd.Parameters.AddWithValue("@semester", semesterValue);
                        cmd.Parameters.AddWithValue("@modlecredits", modlecreditsValue);
                        cmd.Parameters.AddWithValue("@modlegrades", modlegrades);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Inserted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No rows affected.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


    }
    }
}
