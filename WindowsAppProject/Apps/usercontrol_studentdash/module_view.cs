using System;
using System.Data.OleDb;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppProject.Apps.usercontrol_studentdash
{
    public partial class module_view : UserControl
    {
        private string connectionstr = dbconnection.Instance.ConnectionString;

        public module_view()
        {
            InitializeComponent();
            panel2.Scroll += panel_Scroll;
            panel3.Scroll += panel_Scroll;
            panel4.Scroll += panel_Scroll;
            panel5.Scroll += panel_Scroll;
            panel6.Scroll += panel_Scroll;
        }

        public async Task loadcontent(string searchCriteria = "")
        {
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            panel4.Controls.Clear();
            panel5.Controls.Clear();
            panel6.Controls.Clear();

            int yoffset = 0;
            string studentid = StudentIdGetter.StudentId;

            using (OleDbConnection conn = new OleDbConnection(connectionstr))
            {
                await conn.OpenAsync();

                string sqlcmd = "SELECT studentmoduleresult.Semester, studentmoduleresult.ModuleCode, studentmoduleresult.ModuleName, studentmoduleresult.ModuleCredits, studentmoduleresult.ModuleGrade FROM studentmoduleresult WHERE StudentID = ?";

                if (!string.IsNullOrEmpty(searchCriteria))
                {
                    sqlcmd += " AND (studentmoduleresult.ModuleCode LIKE ? OR studentmoduleresult.ModuleName LIKE ?)";
                }

                using (OleDbCommand cmd = new OleDbCommand(sqlcmd, conn))
                {
                    cmd.Parameters.AddWithValue("?", studentid);

                    if (!string.IsNullOrEmpty(searchCriteria))
                    {
                        cmd.Parameters.AddWithValue("?", "%" + searchCriteria + "%");
                        cmd.Parameters.AddWithValue("?", "%" + searchCriteria + "%");
                    }

                    try
                    {
                        using (OleDbDataReader reader = (OleDbDataReader)await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                int semester = reader.GetInt32(0);
                                string mdlcode = reader.GetString(1);
                                string mdlname = reader.GetString(2);
                                int mdlcredits = reader.GetInt32(3);
                                string mdlgrade = reader.GetString(4);

                                Invoke((MethodInvoker)delegate
                                {
                                    Label lbl = new Label();
                                    lbl.ForeColor = Color.White;
                                    lbl.Location = new Point(0, 0 + yoffset);
                                    lbl.BackColor = Color.FromArgb(132, 169, 172);
                                    lbl.Text = semester.ToString();
                                    lbl.AutoSize = false;
                                    lbl.Height = 50;
                                    lbl.Width = panel2.Width;
                                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                                    lbl.Font = new Font("Microsoft Sans Serif", 18);
                                    panel2.Controls.Add(lbl);


                                    Label lbl2 = new Label();
                                    lbl2.ForeColor = Color.White;
                                    lbl2.Location = new Point(0, 0 + yoffset);
                                    lbl2.BackColor = Color.FromArgb(132, 169, 172);
                                    lbl2.Text = mdlcode;
                                    lbl2.AutoSize = false;
                                    lbl2.Height = 50;
                                    lbl2.Width = panel3.Width;
                                    lbl2.TextAlign = ContentAlignment.MiddleCenter;
                                    lbl2.Font = new Font("Microsoft Sans Serif", 18);
                                    panel3.Controls.Add(lbl2);

                                    Label lbl3 = new Label();
                                    lbl3.ForeColor = Color.White;
                                    lbl3.Location = new Point(0, 0 + yoffset);
                                    lbl3.BackColor = Color.FromArgb(132, 169, 172);
                                    lbl3.Text = mdlname;
                                    lbl3.AutoSize = false;
                                    lbl3.Height = 50;
                                    lbl3.Width = panel4.Width;
                                    lbl3.TextAlign = ContentAlignment.MiddleCenter;
                                    lbl3.Font = new Font("Microsoft Sans Serif", 18);
                                    panel4.Controls.Add(lbl3);

                                    Label lbl4 = new Label();
                                    lbl4.ForeColor = Color.White;
                                    lbl4.Location = new Point(0, 0 + yoffset);
                                    lbl4.BackColor = Color.FromArgb(132, 169, 172);
                                    lbl4.Text = mdlcredits.ToString();
                                    lbl4.AutoSize = false;
                                    lbl4.Height = 50;
                                    lbl4.Width = panel5.Width;
                                    lbl4.TextAlign = ContentAlignment.MiddleCenter;
                                    lbl4.Font = new Font("Microsoft Sans Serif", 18);
                                    panel5.Controls.Add(lbl4);

                                    Label lbl5 = new Label();
                                    lbl5.ForeColor = Color.White;
                                    lbl5.Location = new Point(0, 0 + yoffset);
                                    lbl5.BackColor = Color.FromArgb(132, 169, 172);
                                    lbl5.Text = mdlgrade;
                                    lbl5.AutoSize = false;
                                    lbl5.Height = 50;
                                    lbl5.Width = panel6.Width;
                                    lbl5.TextAlign = ContentAlignment.MiddleCenter;
                                    lbl5.Font = new Font("Microsoft Sans Serif", 18);
                                    panel6.Controls.Add(lbl5);

                                });

                                yoffset += 57;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
        public string placeholderText = "Search modules here";
        private async void module_view_Load(object sender, EventArgs e)
        {


            await Task.Run(() => loadcontent());

            textBox1.Text = placeholderText;
            textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string searchCriteria = textBox1.Text;
            loadcontent(searchCriteria);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void SyncVerticalScroll(ScrollEventArgs e)
        {
            panel2.VerticalScroll.Value = e.NewValue;
            panel3.VerticalScroll.Value = e.NewValue;
            panel4.VerticalScroll.Value = e.NewValue;
            panel5.VerticalScroll.Value = e.NewValue;
            panel6.VerticalScroll.Value = e.NewValue;
        }
        private void panel_Scroll(object sender, ScrollEventArgs e)
        {
            SyncVerticalScroll(e);
        }

    }
}