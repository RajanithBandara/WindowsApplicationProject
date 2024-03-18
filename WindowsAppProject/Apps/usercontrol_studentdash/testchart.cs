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

namespace WindowsAppProject.Apps.usercontrol_studentdash
{
    public partial class testchart : UserControl
    {
        public testchart()
        {
            InitializeComponent();
            InitializePlot();
        }

        private void InitializePlot()
        {
            var plotModel = new PlotModel { Title = "Simple Line Plot" };

            var series = new LineSeries();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                series.Points.Add(new DataPoint(i, rand.Next(1, 100)));
            }

            plotModel.Series.Add(series);
            plotView1.Model = plotModel;
            
        }

        private void testchart_Load(object sender, EventArgs e)
        {

        }
    }
}
