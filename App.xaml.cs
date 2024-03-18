using DNDHelper.Model;
using DNDHelper.Stores;
using DNDHelper.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace DNDHelper
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore navigationStore = new()
            {
                CurrentViewModel = new HomeViewModel()
            };

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)

        };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
