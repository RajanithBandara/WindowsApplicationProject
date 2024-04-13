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
        }

        public async Task loadcontent()
        {
            int yoffset = 50;
            string studentid = StudentIdGetter.StudentId;

            using (OleDbConnection conn = new OleDbConnection(connectionstr))
            {
                await conn.OpenAsync();

                string sqlcmd = "SELECT studentmoduleresult.Semester, studentmoduleresult.ModuleCode, studentmoduleresult.ModuleName, studentmoduleresult.ModuleCredits, studentmoduleresult.ModuleGrade FROM studentmoduleresult where StudentID = ?";
                using (OleDbCommand cmd = new OleDbCommand(sqlcmd, conn))
                {
                    cmd.Parameters.AddWithValue("?", studentid);

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
                                    lbl.Location = new Point(0,75 + yoffset);
                                    lbl.BackColor = Color.DarkGray;
                                    lbl.Text = semester.ToString();
                                    lbl.AutoSize = false;
                                    lbl.Height = 50;
                                    lbl.Width = panel2.Width;
                                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                                    lbl.Font = new Font("Microsoft Sans Serif", 18);
                                    panel2.Controls.Add(lbl);

                                    Label lbl2 = new Label();
                                    lbl2.ForeColor = Color.White;
                                    lbl2.Location = new Point(0, 75 + yoffset);
                                    lbl2.BackColor = Color.DarkGray;
                                    lbl2.Text = mdlcode;
                                    lbl2.AutoSize = false;
                                    lbl2.Height = 50;
                                    lbl2.Width = panel3.Width;
                                    lbl2.TextAlign = ContentAlignment.MiddleCenter;
                                    lbl2.Font = new Font("Microsoft Sans Serif", 18);
                                    panel3.Controls.Add(lbl2);

                                    Label lbl3 = new Label();
                                    lbl3.ForeColor = Color.White;
                                    lbl3.Location = new Point(0, 75 + yoffset);
                                    lbl3.BackColor = Color.DarkGray;
                                    lbl3.Text = mdlname;
                                    lbl3.AutoSize = false;
                                    lbl3.Height = 50;
                                    lbl3.Width = panel4.Width;
                                    lbl3.TextAlign = ContentAlignment.MiddleCenter;
                                    lbl3.Font = new Font("Microsoft Sans Serif", 18);
                                    panel4.Controls.Add(lbl3);

                                    Label lbl4 = new Label();
                                    lbl4.ForeColor = Color.White;
                                    lbl4.Location = new Point(0, 75 + yoffset);
                                    lbl4.BackColor = Color.DarkGray;
                                    lbl4.Text = mdlcredits.ToString();
                                    lbl4.AutoSize = false;
                                    lbl4.Height = 50;
                                    lbl4.Width = panel5.Width;
                                    lbl4.TextAlign = ContentAlignment.MiddleCenter;
                                    lbl4.Font = new Font("Microsoft Sans Serif", 18);
                                    panel5.Controls.Add(lbl4);

                                    Label lbl5 = new Label();
                                    lbl5.ForeColor = Color.White;
                                    lbl5.Location = new Point(0, 75 + yoffset);
                                    lbl5.BackColor = Color.DarkGray;
                                    lbl5.Text = mdlgrade;
                                    lbl5.AutoSize = false;
                                    lbl5.Height = 50;
                                    lbl5.Width = panel6.Width;
                                    lbl5.TextAlign = ContentAlignment.MiddleCenter;
                                    lbl5.Font = new Font("Microsoft Sans Serif", 18);
                                    panel6.Controls.Add(lbl5);
                                });

                                yoffset += 50;
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

        private async void module_view_Load(object sender, EventArgs e)
        {
            await Task.Run(() => loadcontent());
        }
    }
}
