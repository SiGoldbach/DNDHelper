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

        /**
         * Here below are the functions for navigation between the different windows 
         * */

        private void NavigateToMonsterTab(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The MonsterButton is clicked");
            
            

        }
        private void NavigateToItemTab(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The ItemTab is clicked");



        }
        private void NavigateToHomeTab(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The HomeTab is clicked");



        }
        private void NavigateToCharacterTab(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The CharacterTab is clicked");



        }

    }
}