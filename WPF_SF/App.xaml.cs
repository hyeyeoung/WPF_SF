using System.Configuration;
using System.Data;
using System.Windows;
using WPF_SF.Views;

namespace WPF_SF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow main = new();
            main.ShowDialog();
        }
    }

}
