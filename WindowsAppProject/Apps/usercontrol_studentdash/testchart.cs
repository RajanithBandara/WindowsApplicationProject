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
            var Plotmodel = new PlotModel { Title = "Student Detials" };
            var series1 = new LineSeries
            {
                Title = "Marks",
                MarkerType = MarkerType.Circle
            };
            series1.Points.Add(new DataPoint(0, 0));
            series1.Points.Add(new DataPoint(1, 10));
            series1.Points.Add(new DataPoint(2, 20));
            series1.Points.Add(new DataPoint(3, 30));
            series1.Points.Add(new DataPoint(4, 40));
        }

        

        private void testchart_Load(object sender, EventArgs e)
        {

        }
    }
}
