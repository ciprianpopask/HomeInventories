using Prism.Modularity;
using Prism.Regions;
using System;
using HI.VirtualDesk.GUI.ApplicationMenu;
using HI.VirtualDesk.GUI.Common;

namespace HI.VirtualDesk.GUI
{
    public class ModuleInit : IModule
    {
        public ModuleInit(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion(PrismRegionNames.ShellMenuRegion, typeof (ApplicationMenuView));
        }

        public void Initialize()
        {
        
        }
    }
}