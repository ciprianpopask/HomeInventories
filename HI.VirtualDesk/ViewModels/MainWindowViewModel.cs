using HI.VirtualDesk.TextResources;
using Prism.Mvvm;

namespace HI.VirtualDesk.ViewModels
{
    /// <summary>
    /// App main window's VM
    /// </summary>
    public class MainWindowViewModel : BindableBase
    {
        private string mApplicationTitle = Texts.AppTitle_Text;

        public string ApplicationTitle
        {
            get
            {
                return mApplicationTitle;
            }
            set
            {
                SetProperty(ref mApplicationTitle, value);
            }
        }

    }
}
