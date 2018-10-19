using DomainLib;
using System.Windows;

namespace WpfApp
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var p = new Person();
            var window = new MainWindow();
            window.DataContext = p;
            window.Show();
        }
    }
}
