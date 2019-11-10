using BLL.Modules;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universe.ViewModel;

namespace Universe.Infrastructure
{
    public class VMLocator
    {
        IReadOnlyKernel kernel;
        public VMLocator()
        {
            kernel = new StandardKernel(new HeavenlyBodyNinjectModule());
        }
      public MainVievModel MainViewModel
        {
            get => kernel.Get<MainVievModel>();
        } 
    }
}
