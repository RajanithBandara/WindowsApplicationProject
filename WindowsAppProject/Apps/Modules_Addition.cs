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

            // Parse numeric values
            int semesterValue = int.Parse(textBox4.Text);
            int modlecreditsValue = int.Parse(textBox5.Text);
            string modlegrades = textBox6.Text;

            NpgsqlConnection conn = new NpgsqlConnection(connectionstr);
            conn.Open();

            string module = "INSERT INTO public.studentmoduleresult(stdid, modlecode, modlename, semester, modlecredits, modlegrades) " +
                            "VALUES (@stdid, @modlecode, @modlename, @semester, @modlecredits, @modlegrades)";

            NpgsqlCommand cmd = new NpgsqlCommand(module, conn);
            cmd.Parameters.AddWithValue("@stdid", stdid);
            cmd.Parameters.AddWithValue("@modlecode", modlecode);
            cmd.Parameters.AddWithValue("@modlename", modlename);
            cmd.Parameters.AddWithValue("@semester", semesterValue);
            cmd.Parameters.AddWithValue("@modlecredits", modlecreditsValue);
            cmd.Parameters.AddWithValue("@modlegrades", modlegrades);

            cmd.ExecuteNonQuery();

            conn.Close();


        }
    }
}
