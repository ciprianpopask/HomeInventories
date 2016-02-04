using Microsoft.Practices.Unity;
using Prism.Unity;
using HI.VirtualDesk.Views;
using System.Windows;
using Prism.Logging;

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

        protected override void InitializeModules()
        {
            base.InitializeModules();
        }

       
    }
}
