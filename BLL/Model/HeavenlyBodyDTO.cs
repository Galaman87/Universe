using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universe.BLL.Model
{
    public class HeavenlyBodyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public double Mass { get; set; }
        public int EMass { get; set; }
        public double Diameter { get; set; }
        public string ImageUrl { get; set; }


    }
}
