using System.Windows;

namespace WPFLearn
{
    public partial class MainWindow : Window
    {
        bool isRunning = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        //{
        //    if (isRunning)
        //    {
        //        tbStatus.Text = "Running...";
        //        btnToggleRun.Content = "Stop";
        //    }
        //    else
        //    {
        //        tbStatus.Text = "Stopped";
        //        btnToggleRun.Content = "Start";
        //    }

        //    isRunning = !isRunning;
        //}
    }
}