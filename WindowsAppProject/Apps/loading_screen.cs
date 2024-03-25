using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsAppProject.Apps
{
    public partial class loading_screen : Form
    {
        public loading_screen()
        {
            InitializeComponent();
        }

        // Load event of the loading screen form
        private void loading_screen_Load(object sender, EventArgs e)
        {
            // Start loading process in a separate thread
            BackgroundWorker loaderWorker = new BackgroundWorker();
            loaderWorker.WorkerReportsProgress = true;

            // Define event handlers for loading process
            loaderWorker.DoWork += LoaderWorker_DoWork;
            loaderWorker.ProgressChanged += LoaderWorker_ProgressChanged;
            loaderWorker.RunWorkerCompleted += LoaderWorker_RunWorkerCompleted;

            // Start the background worker
            loaderWorker.RunWorkerAsync();
        }

        // Method to simulate loading process
        private void LoaderWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            // Simulate loading steps
            // Step 1: Loading data
            for (int i = 0; i <= 33; i++)
            {
                System.Threading.Thread.Sleep(100); // Simulate loading delay
                worker.ReportProgress(i);
            }

            // Step 2: Initializing components
            for (int i = 34; i <= 66; i++)
            {
                System.Threading.Thread.Sleep(100); // Simulate loading delay
                worker.ReportProgress(i);
            }

            // Step 3: Preparing user interface
            for (int i = 67; i <= 100; i++)
            {
                System.Threading.Thread.Sleep(100); // Simulate loading delay
                worker.ReportProgress(i);
            }
        }

        // Event handler for reporting progress
        private void LoaderWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update progress bar value
            progressBar1.Value = e.ProgressPercentage;
        }

        // Event handler for completion of loading process
        private void LoaderWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Close the loading screen form
            this.Close();
        }
    }
}
