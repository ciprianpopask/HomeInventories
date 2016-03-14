#region USING DIRECTIVES

using System;
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
        /// <summary>
        ///     Initializes a new instance of the <see cref="VMBase" /> class.
        /// </summary>
        /// <param name="aggregator">The aggregator.</param>
        /// <param name="regionManager">The region manager.</param>
        /// <exception cref="System.ArgumentNullException">
        ///     regionManager or centerManager or repository
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

            Manager = regionManager;
            EventAggregator = aggregator;
        }

        public IRegionManager Manager
        {
            get;
            private set;
        }

        public IEventAggregator EventAggregator
        {
            get;
            private set;
        }

        #region Implementation of INavigationAware

        /// <summary>
        /// Called when the implementer has been navigated to.
        /// </summary>
        /// <param name="navigationContext">The navigation context.</param>
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called to determine if this instance can handle the navigation request.
        /// </summary>
        /// <param name="navigationContext">The navigation context.</param>
        /// <returns>
        /// <see langword="true"/> if this instance accepts the navigation request; otherwise, <see langword="false"/>.
        /// </returns>
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when the implementer is being navigated away from.
        /// </summary>
        /// <param name="navigationContext">The navigation context.</param>
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}