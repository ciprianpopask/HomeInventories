#region USING DIRECTIVES

using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;

#endregion

namespace HI.VirtualDesk.GUI.Common
{
    /// <summary>
    /// Base class for all ViewModels of the application
    /// </summary>
    public class VMBase : BindableBase, INavigationAware
    {
        #region Private members and ctor

        private List<RelayCommand> mCommands;
        private RelayCommand mNavigateCommand;

        /// <summary>
        ///     Initializes a new instance of the <see cref="VMBase" /> class.
        /// </summary>
        /// <param name="aggregator">The aggregator.</param>
        /// <param name="regionManager">The region manager.</param>
        /// <exception cref="System.ArgumentNullException">
        ///     Any parameter
        /// </exception>
        public VMBase(
            IEventAggregator aggregator,
            IRegionManager regionManager)

        {
            if (regionManager == null)
            {
                throw new ArgumentNullException("regionManager");
            }

            if (aggregator == null)
            {
                throw new ArgumentNullException("aggregator");
            }

            RegionManager = regionManager;
            EventAggregator = aggregator;

            NavigateCommand = new RelayCommand(NavigateCommandExecute, NavigateCommandCanExecute);

        }

        #endregion

        #region Public properties

        /// <summary>
        /// Prisdm RegionManager 
        /// </summary>
        public IRegionManager RegionManager
        {
            get;
        }

        /// <summary>
        /// Prism EventAggregator
        /// </summary>
        public IEventAggregator EventAggregator
        {
            get;
            private set;
        }

        /// <summary>
        /// Commands of this ViewModel
        /// </summary>
        public List<RelayCommand> Commands
        {
            get
            {
                return mCommands;
            }
            set
            {
                mCommands = value;
                SetProperty(ref mCommands, value);
            }
        }

        /// <summary>
        /// Default version of a command to request navigation via <see cref="IRegionManager"/>
        /// </summary>
        public RelayCommand NavigateCommand
        {
            get
            {
                return mNavigateCommand;
            }
            set
            {
                mNavigateCommand = value;
                SetProperty(ref mNavigateCommand, value);
            }
        }

        #endregion

        #region Navigation

        /// <summary>
        /// Called when the implementer has been navigated to.
        /// </summary>
        /// <param name="navigationContext">The navigation context.</param>
        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }

        /// <summary>
        /// Called to determine if this instance can handle the navigation request.
        /// </summary>
        /// <param name="navigationContext">The navigation context.</param>
        /// <returns>
        /// <see langword="true"/> if this instance accepts the navigation request; otherwise, <see langword="false"/>.
        /// </returns>
        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        /// <summary>
        /// Called when the implementer is being navigated away from.
        /// </summary>
        /// <param name="navigationContext">The navigation context.</param>
        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        /// <summary>
        /// Determines if the VM may request navigation to supplied parameter
        /// </summary>
        /// <param name="address">Must be non-null in order to be used for navigation</param>
        /// <returns></returns>
        public virtual bool NavigateCommandCanExecute(object address)
        {
            return !string.IsNullOrEmpty(address?.ToString());
        }

        /// <summary>
        /// Executes navigation request to supplied parameter
        /// </summary>
        /// <param name="address">Source string used to build Uri for navigation request</param>
        public virtual void NavigateCommandExecute(object address)
        {
            RegionManager.RequestNavigate(PrismRegionNames.ShellMenuRegion,
                new Uri(address.ToString(), UriKind.RelativeOrAbsolute));
        }

        #endregion
    }
}