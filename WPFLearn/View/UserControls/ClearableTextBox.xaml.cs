using System.Windows;
using System.Windows.Controls;

namespace WPFLearn.View.UserControls
{
    public partial class ClearableTextBox : System.Windows.Controls.UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string placeholder = string.Empty;

        public  string Placeholder
        {
            get { return placeholder; }
            set 
            { 
                placeholder = value; 
                tbPlaceholder.Text = placeholder;
            }
        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                tbPlaceholder.Visibility = Visibility.Visible;
            } else
            {
                tbPlaceholder.Visibility = Visibility.Hidden;
            }
        }
    }
}
