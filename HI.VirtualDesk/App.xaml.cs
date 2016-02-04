using System;
using System.Diagnostics;
using System.Windows;

namespace HI.VirtualDesk
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Application.Startup" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.StartupEventArgs" /> that contains the event data.</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                AppDomain.CurrentDomain.UnhandledException += AppDomainUnhandledException;
                base.OnStartup(e);
                Bootstrapper bootstrapper = new Bootstrapper();
                bootstrapper.Run();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private static void AppDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException(e.ExceptionObject as Exception);
        }

        private static void HandleException(Exception ex)
        {
            if (ex == null)
                return;
            Debug.WriteLine("!!! Service Client App - unhandled exception:");
            Debug.WriteLine(ex.StackTrace);
            Debug.WriteLine(ex.InnerException);
            MessageBox.Show(ex.Message, "Service Client App - unhandled exception", MessageBoxButton.OK, MessageBoxImage.Error);

            Environment.Exit(1);
        }
    }
}
