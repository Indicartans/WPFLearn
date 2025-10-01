using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Winforms = System.Windows.Forms;

namespace WPFLearn
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string boundText = string.Empty;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundText; }
            set 
            { 
                boundText = value; 
                OnPropertyChanged("BoundText");
            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "Text set from code behind.";
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("Do you agree?", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes) {
                tbInfo.Text = "Agreed";
            } else
            {
                tbInfo.Text = "Not agreed";
            }
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "C3 source file | *.cs";
            openFileDialog.Title = "Select a C# source file";
            //openFileDialog.InitialDirectory = "D:\\go";
            openFileDialog.Multiselect = true;

            bool? success = openFileDialog.ShowDialog();

            if(success ==  true)
            {
                // Get the selected file path
                string[] filePaths = openFileDialog.FileNames;
                // get only the file name
                string[] fileNames = openFileDialog.SafeFileNames;

                //tbFilePath.Text = fileNames;
            }
        }

        private void btnOpenFolder_Click(object sender, RoutedEventArgs e)
        {
            Winforms.FolderBrowserDialog dialog = new Winforms.FolderBrowserDialog();
            dialog.InitialDirectory = "D:\\go";
            Winforms.DialogResult result = dialog.ShowDialog();


            if (result == Winforms.DialogResult.OK)
            {
                string folderPath = dialog.SelectedPath;
                tbFolderPath.Text = folderPath;
            }
            else
            {
                tbFolderPath.Text = "No folder selected.";
            }
        }
    }
}