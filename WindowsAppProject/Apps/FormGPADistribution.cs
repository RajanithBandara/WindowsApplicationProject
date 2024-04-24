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
    public partial class FormGPADistribution : Form
    {
        public FormGPADistribution()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        /*
        private void FormGPADistribution_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gPADatabaseDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.gPADatabaseDataSet.Table);

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                tableBindingSource.EndEdit();
                tableTableAdapter.Update(gPADatabaseDataSet.Table);
                MessageBox.Show("Record Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void btnLoad_Click(object sender, EventArgs e)
        {

            chart1.Series[0].XValueMember = "Grade";
            chart1.Series[0].YValueMembers = "Grade";

            chart1.Series[1].XValueMember = "SE";
            chart1.Series[1].YValueMembers = "SE";

            chart1.Series[2].XValueMember = "CS";
            chart1.Series[2].YValueMembers = "CS";

            chart1.Series[3].XValueMember = "DS";
            chart1.Series[3].YValueMembers = "DS";

            chart1.Series[4].XValueMember = "CN";
            chart1.Series[4].YValueMembers = "CN";





           // chart1.DataSource = gPADatabaseDataSet.Table;
            //chart1.DataBind();


        }
    }
}

