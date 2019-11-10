using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universe.BLL.Model;
using Universe.DAL.Repositories;
using Universe.DAL.Model;


namespace Universe.BLL.Services
{
    public  class HeavenlyBodyDTOService : IService<HeavenlyBodyDTO>
    {
        IRepository<HeavenlyBody> repo;
        public HeavenlyBodyDTOService(IRepository<HeavenlyBody> repo)
        {
            this.repo = repo;
        }
        public void Create(HeavenlyBodyDTO obj)
        {
            HeavenlyBody body = new HeavenlyBody
            {
                Id = obj.Id,
                Name = obj.Name,
                Type = obj.Type,
                Mass = obj.Mass,
                EMass = obj.EMass,
                Diameter = obj.Diameter,
                ImageUrl = obj.ImageUrl
            };
            repo.Create(body);
        }

        public void Delete(HeavenlyBodyDTO obj)
        {
            HeavenlyBody bodyDelete = repo.Get(obj.Id);
            repo.Delete(bodyDelete);
        }

        public HeavenlyBodyDTO Get(int id)
        {
            HeavenlyBody bodyGet = repo.Get(id);
            return new HeavenlyBodyDTO
            {
                Id = bodyGet.Id,
                Name = bodyGet.Name,
                Type = bodyGet.Type,
                Mass = bodyGet.Mass,
                EMass = bodyGet.EMass,
                Diameter = bodyGet.Diameter,
                ImageUrl = bodyGet.ImageUrl

            };
        }

        public IEnumerable<HeavenlyBodyDTO> GetAll()
        {
            return repo
                    .GetAll()
                     .Select(x => new HeavenlyBodyDTO
                     {
                         Id = x.Id,
                         Name = x.Name,
                         Type = x.Type,
                         Mass = x.Mass,
                         EMass = x.EMass,
                         Diameter = x.Diameter,
                         ImageUrl = x.ImageUrl
                     });
        }

        public void Update(HeavenlyBodyDTO obj)
        {
            HeavenlyBody bodyUpdate = repo.Get(obj.Id);
            bodyUpdate.Name = obj.Name;
            bodyUpdate.Type = obj.Type;
            bodyUpdate.Mass = obj.Mass;
            bodyUpdate.EMass = obj.EMass;
            bodyUpdate.Diameter = obj.Diameter;
            bodyUpdate.ImageUrl = obj.ImageUrl;

            repo.Update(bodyUpdate);
        }
    }
}
