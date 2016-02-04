using Microsoft.Practices.Unity;
using Prism.Unity;
using HI.VirtualDesk.Views;
using System.Windows;
using Prism.Logging;
using Prism.Modularity;

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

        /// <summary>
        /// Creates the ModuleCatalog by scanning all assemblies within the application directory.
        /// </summary>
        /// <returns></returns>
        protected override IModuleCatalog CreateModuleCatalog()
        {
            var moduleCatalog = new ConfigurationModuleCatalog();
           
            return moduleCatalog;
        }


        /// <summary>
        /// Initializes the modules. May be overwritten in a derived class to use a custom Modules Catalog
        /// </summary>
        protected override void InitializeModules()
        {
            base.InitializeModules();
        }

       
    }
}
