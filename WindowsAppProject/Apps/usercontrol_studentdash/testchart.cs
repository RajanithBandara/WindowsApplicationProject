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
using OxyPlot.Series;
//using System.Windows.Forms.DataVisualization.Charting;

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
            var plotmodel = new PlotModel { Title = "Student Details" };
            var series = new LineSeries {
                Title = "Test",
                MarkerType = MarkerType.Circle
            };
            series.Points.Add(new DataPoint(1, 1));
            series.Points.Add(new DataPoint(2, 2));
            series.Points.Add(new DataPoint(3, 3));
            series.Points.Add(new DataPoint(4, 4));
            series.Points.Add(new DataPoint(5, 5));

            plotmodel.Series.Add(series);

            var plotView = new PlotView
            {
                Dock = DockStyle.Fill,
                Model = plotmodel,
            };

            rjPanel1.Controls.Add(plotView);
        }

        

        private void testchart_Load(object sender, EventArgs e)
        {

        }
    }
}
