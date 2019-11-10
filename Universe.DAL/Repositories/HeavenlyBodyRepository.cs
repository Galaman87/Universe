using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Universe.DAL.Model;

namespace Universe.DAL.Repositories
{
    public class HeavenlyBodyRepository : IRepository<HeavenlyBody>
    {
        List<HeavenlyBody> bodies = HeavenlyBody.GetHeavenlyBody().ToList();
        public void Create(HeavenlyBody obj)
        {
            bodies.Add(obj);
        }

        public void Delete(HeavenlyBody obj)
        {
            bodies.Remove(obj);
        }

        public HeavenlyBody Get(int id)
        {
            return bodies.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<HeavenlyBody> GetAll()
        {
            return bodies;
        }

        public void Update(HeavenlyBody obj)
        {
            HeavenlyBody body = this.Get(obj.Id);
            body.Name = obj.Name;
            body.Type = obj.Type;
            body.Mass = obj.Mass;
            body.EMass = obj.EMass;
            body.Diameter = obj.Diameter;
            body.ImageUrl = obj.ImageUrl;
        }
    }
}
