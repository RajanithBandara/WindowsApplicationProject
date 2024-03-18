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
        private PlotModel plotModel;
        private Label valueLabe1;
        private LineSeries series;
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

        private void Initializecontrols()
        {
            valueLabe1 = new Label();
            valueLabe1.Text = "Last value";
            valueLabe1.AutoSize = true;
            valueLabe1.Location = new System.Drawing.Point(10, 10);
            this.Controls.Add(valueLabe1);

        }

        private void UpdateValueLabel(double value)
        {
            valueLabe1.Text = "Last value :" + value.ToString();
        }

        private void plotView1_MouseClick(object sender, MouseEventArgs e)
        {
            double lastvalue = series.Points[series.Points.Count - 1].Y;
            UpdateValueLabel(lastvalue);
        }

        private void testchart_Load(object sender, EventArgs e)
        {

        }
    }
}
