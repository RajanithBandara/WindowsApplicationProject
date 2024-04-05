using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.WindowsForms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsAppProject.Apps.usercontrol_studentdash
{
    public partial class testchart : UserControl
    {
        public testchart()
        {
            InitializeComponent();
            InitializeChart();
        }

        public void InitializeChart()
        {
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Line;

            series.Points.AddXY(1, 1);
            series.Points.AddXY(2, 2);

            chart.Series.Add(series);

            Controls.Add(chart);
        }

        

        private void testchart_Load(object sender, EventArgs e)
        {

        }
    }
}
