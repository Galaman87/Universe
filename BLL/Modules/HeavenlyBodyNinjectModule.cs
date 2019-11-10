using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universe.BLL.Model;
using Universe.BLL.Services;
using Universe.DAL.Model;
using Universe.DAL.Repositories;

namespace BLL.Modules
{
    public class HeavenlyBodyNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<HeavenlyBody>>().To<HeavenlyBodyRepository>();
            Bind<IService<HeavenlyBodyDTO>>().To<HeavenlyBodyDTOService>();
        }
    }
   
}
