using System.Collections;
using System.Windows;

namespace WPFLearn
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lvEntries.Items.Add("Item 1");
            lvEntries.Items.Add("Item 2");
            lvEntries.Items.Add("Item 3");
        }

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(lvInput.Text);
            lvInput.Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //int index = lvEntries.SelectedIndex;
            //object item = lvEntries.SelectedItem;
            var items = lvEntries.SelectedItems;

            var result = System.Windows.MessageBox.Show($"Are you sure to delete '{items.Count}' item(s)?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if( result == MessageBoxResult.Yes)
            {
                var itemsList = new ArrayList(items);
                foreach(var item in itemsList)
                {
                    lvEntries.Items.Remove(item);
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}