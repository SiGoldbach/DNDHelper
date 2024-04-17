using DNDHelper.Model;
using DNDHelper.Stores;
using DNDHelper.ViewModels;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Windows;

namespace DNDHelper
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;
        private readonly MainViewModel _mainViewModel;
        public App()
        {
            _navigationStore = new NavigationStore();
            _mainViewModel = new MainViewModel(_navigationStore);

        }
        protected override void OnStartup(StartupEventArgs e)
        {




            MainWindow = new MainWindow()
            {

                DataContext = new MainViewModel(_navigationStore)

        };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
