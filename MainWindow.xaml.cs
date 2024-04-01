using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DNDHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void dragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left )
            {
                DragMove();
            }

        }

        private void EnterNavigation(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton != null)
                {
                    radioButton.IsChecked = true;
                    e.Handled = true;
                }
            }

        }

        

    }
}