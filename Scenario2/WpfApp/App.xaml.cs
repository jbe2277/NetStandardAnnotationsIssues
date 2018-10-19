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
            PersonRepository.AddPerson(p);

            var window = new MainWindow();
            window.DataContext = p;
            window.Show();
        }
    }
}
