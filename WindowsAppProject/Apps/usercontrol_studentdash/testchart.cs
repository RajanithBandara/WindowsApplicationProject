using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace WindowsAppProject.Apps.usercontrol_studentdash
{
    public partial class testchart : UserControl
    {
        private readonly string connectionstr = dbconnection.Instance.ConnectionString;
        private int semesters;
        private string userid;
        private PlotView plotView;

        public testchart()
        {
            InitializeComponent();
            ApplyMaterialSkin();
            userid = StudentIdGetter.StudentId;
            LoadData();
        }

        private void ApplyMaterialSkin()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void LoadData()
        {
            semesters = GetMaxSemester();
            PlotGPAProgression();
        }

        private int GetMaxSemester()
        {
            if (string.IsNullOrEmpty(userid))
                return 0;

            string sqlcmd = "SELECT MAX(Semester) AS max_semester FROM studentmoduleresult WHERE StudentID = @userid";

            using (OleDbConnection conn = new OleDbConnection(connectionstr))
            using (OleDbCommand cmd = new OleDbCommand(sqlcmd, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@userid", userid);
                object result = cmd.ExecuteScalar();
                conn.Close();

                return result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
        }

        private void PlotGPAProgression()
        {
            plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
            rjPanel1.Controls.Add(plotView);

            var plotModel = new PlotModel { Title = "GPA Progression" };
            var lineSeries = new LineSeries { Title = "GPA" };

            for (int i = 1; i <= semesters; i++)
            {
                Dictionary<string, int> moduleCredit = GetModuleCredits(i);
                double totalCredits = 0;
                double totalGradePoints = 0;

                foreach (var kvp in moduleCredit)
                {
                    string grade = kvp.Key;
                    int credit = kvp.Value;
                    totalCredits += credit;
                    totalGradePoints += GetGradePoint(grade) * credit;
                }

                double gpa = totalCredits > 0 ? totalGradePoints / totalCredits : 0;
                lineSeries.Points.Add(new DataPoint(i, gpa));
            }

            plotModel.Series.Add(lineSeries);

            plotView.Model = plotModel;
        }

        private Dictionary<string, int> GetModuleCredits(int semester)
        {
            var moduleCredits = new Dictionary<string, int>();
            string sqlcmd = $"SELECT ModuleGrade, ModuleCredits FROM studentmoduleresult WHERE StudentID = @userid AND Semester = @semester";

            using (OleDbConnection conn = new OleDbConnection(connectionstr))
            using (OleDbCommand cmd = new OleDbCommand(sqlcmd, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@semester", semester);

                try
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string grade = reader.GetString(0);
                            int credit = reader.GetInt32(1);
                            moduleCredits[grade] = credit;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }
            }

            return moduleCredits;
        }

        private double GetGradePoint(string grade)
        {
            switch (grade)
            {
                case "A+": return 4.0;
                case "A": return 4.0;
                case "A-": return 3.7;
                case "B+": return 3.3;
                case "B": return 3.0;
                case "B-": return 2.7;
                case "C+": return 2.3;
                case "C": return 2.0;
                case "C-": return 1.7;
                case "D": return 1.0;
                default: return 0.0;
            }
        }
    }
}
