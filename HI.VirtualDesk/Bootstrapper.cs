using Microsoft.Practices.Unity;
using Prism.Unity;
using HI.VirtualDesk.Views;
using System.Windows;

namespace HI.VirtualDesk
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
