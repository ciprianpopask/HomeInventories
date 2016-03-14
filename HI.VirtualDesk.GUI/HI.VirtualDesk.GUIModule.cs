using Prism.Modularity;
using Prism.Regions;
using System;
using HI.VirtualDesk.GUI.Common;

namespace HI.VirtualDesk.GUI
{
    public class ModuleInit : IModule
    {
        private IRegionManager mRegionManager;

        public ModuleInit(IRegionManager regionManager)
        {
            mRegionManager = regionManager;
            //mRegionManager.RegisterViewWithRegion(PrismRegionNames.ShellMenuRegion,)



        }

        public void Initialize()
        {
        
        }
    }
}