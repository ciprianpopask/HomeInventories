using Prism.Modularity;
using Prism.Regions;
using System;

namespace HI.VirtualDesk.GUI
{
    public class ModuleInit : IModule
    {
        private IRegionManager mRegionManager;

        public ModuleInit(IRegionManager regionManager)
        {
            mRegionManager = regionManager;
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}