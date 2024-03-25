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
            // Set up the progress bar
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 50; // Adjust animation speed if needed
        }

        private void InitializeTimers()
        {
            // Initialize timers
            timer1 = new Timer();
            timer1.Interval = 2000; // 2000 milliseconds (2 seconds)
            timer1.Tick += Timer1_Tick;

            timer2 = new Timer();
            timer2.Interval = 2000; // 2000 milliseconds (2 seconds)
            timer2.Tick += Timer2_Tick;

            // Start timer1
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Hide label2 and label3, show label1
            label2.Visible = false;
            label3.Visible = false;
            label1.Visible = true;

            // Stop timer1 and start timer2
            timer1.Stop();
            timer2.Start();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            // Hide label1 and label3, show label2
            label1.Visible = false;
            label3.Visible = false;
            label2.Visible = true;

            // Stop timer2 and start timer1
            timer2.Stop();
            timer1.Start();
        }

        public void StartLoading()
        {
            // Show the progress bar
            progressBar1.Visible = true;
        }

        public void StopLoading()
        {
            // Hide the progress bar
            progressBar1.Visible = false;
        }
    }
}
