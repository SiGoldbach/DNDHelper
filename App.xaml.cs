﻿using DNDHelper.Model;
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
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}