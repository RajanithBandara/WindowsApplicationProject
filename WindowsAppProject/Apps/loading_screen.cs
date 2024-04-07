using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace WindowsAppProject.Apps
{
    public partial class loading_screen : Form
    {
        public loading_screen()
        {
            InitializeComponent();
        }

        private void loading_screen_Load(object sender, EventArgs e)
        {
            BackgroundWorker loaderWorker = new BackgroundWorker();
            loaderWorker.DoWork += LoaderWorker_DoWork;
            loaderWorker.RunWorkerCompleted += LoaderWorker_RunWorkerCompleted;

            progressBar1.Style = ProgressBarStyle.Marquee;

            loaderWorker.RunWorkerAsync();
        }

        private void LoaderWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(2000);
        }

        private void LoaderWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Hide();
            maindashboard dashboard = new maindashboard();
            dashboard.ShowDialog();
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            // Not needed if ProgressBar is in Marquee style
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Not needed if label1 is not clickable
        }
    }
}
