using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using MailTools.ViewModels;

namespace MailTools
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var mw = new MainWindow();
            var mwVM = new MainWindowViewModel();
            mw.DataContext = mwVM;
            mw.Show();

            base.OnStartup(e);
        }
    }
}
