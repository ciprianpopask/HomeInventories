using HI.VirtualDesk.GUI.Common;
using HI.VirtualDesk.TextResources;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;

namespace HI.VirtualDesk.ViewModels
{
    /// <summary>
    /// App main window's VM
    /// </summary>
    public class MainWindowViewModel : VMBase
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

        /// <summary>
        ///     Initializes a new instance of the <see cref="VMBase" /> class.
        /// </summary>
        /// <param name="aggregator">The aggregator.</param>
        /// <param name="regionManager">The region manager.</param>
        /// <exception cref="System.ArgumentNullException">
        ///     regionManager or centerManager or repository
        /// </exception>
        public MainWindowViewModel(IEventAggregator aggregator, IRegionManager regionManager) : base(aggregator, regionManager)
        {
        }
    }
}
