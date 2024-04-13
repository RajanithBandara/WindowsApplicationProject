using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;
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

        public testchart()
        {
            InitializeComponent();
            userid = StudentIdGetter.StudentId;
            LoadData();
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
            var plotmodel = new PlotModel { Title = "Student GPA Progression" };
            var series = new LineSeries { Title = "GPA", MarkerType = MarkerType.Circle };

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
                series.Points.Add(new DataPoint(i, gpa));
            }

            plotmodel.Series.Add(series);
            var plotView = new PlotView { Dock = DockStyle.Fill, Model = plotmodel };
            rjPanel1.Controls.Add(plotView);
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
