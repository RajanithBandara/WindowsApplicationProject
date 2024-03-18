using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppProject.Apps.students_chart;

namespace WindowsAppProject.Apps.usercontrol_studentdash
{
    public partial class chartview : UserControl
    {
        public chartview()
        {
            InitializeComponent();
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            var objChart = chart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            //semester1-8
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 8;
            //GPA Value
            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 4;
            //clear
            chart.Series.Clear();
            //random colour
            Random random = new Random();
            //loop rows
            foreach(student_progess p in studentprogessBindingSource.DataSource as List<student_progess>)
            {
                chart.Series.Add(p.Location);
                chart.Series[p.Location].Color= Color.FromArgb(random.Next(256),random.Next(256),random.Next(256));
                chart.Series[p.Location].Legend = "Legend1";
                chart.Series[p.Location].ChartArea = "ChartArea1";
                chart.Series[p.Location].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //adding data
                for(int i = 1;i<=8;i++)
                    chart.Series[p.Location].Points.AddXY(i, Convert.ToInt32(p[$"M{i}"]));
            }
        }



        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
