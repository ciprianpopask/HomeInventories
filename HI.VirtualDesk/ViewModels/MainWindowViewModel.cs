using HI.VirtualDesk.TextResources;
using Prism.Mvvm;

namespace HI.VirtualDesk.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string mtitle = Texts.AppTitle_Text;
        public string Mtitle
        {
            get { return mtitle; }
            set { SetProperty(ref mtitle, value); }
        }
    }
}
