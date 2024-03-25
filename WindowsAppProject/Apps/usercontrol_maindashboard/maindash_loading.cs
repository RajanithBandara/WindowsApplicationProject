using System;
using System.Windows.Forms;

namespace WindowsAppProject.Apps.usercontrol_maindashboard
{
    public partial class maindash_loading : UserControl
    {

        public maindash_loading()
        {
            InitializeComponent();
            InitializeLoadingAnimation();
            InitializeTimers();
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void InitializeLoadingAnimation()
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 50; 
        }

        private void InitializeTimers()
        {

            timer1 = new Timer();
            timer1.Interval = 2000; 
            timer1.Tick += Timer1_Tick;

            timer2 = new Timer();
            timer2.Interval = 2000; 
            timer2.Tick += Timer2_Tick;

            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            label2.Visible = false;
            label3.Visible = false;
            label1.Visible = true;
            timer1.Stop();
            timer2.Start();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
            label3.Visible = false;
            label2.Visible = true;

            timer2.Stop();
            timer1.Start();
        }

        public void StartLoading()
        {
            progressBar1.Visible = true;
        }

        public void StopLoading()
        {
            progressBar1.Visible = false;
        }
    }
}
