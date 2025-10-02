using System.Collections;
using System.Collections.ObjectModel;
using System.Windows;

namespace WPFLearn
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            expanderDetails.IsExpanded = !expanderDetails.IsExpanded;
        }
    }
}