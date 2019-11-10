using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universe.DAL.Model
{
    public class HeavenlyBody
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public double Mass { get; set; }
        public int EMass { get; set; }
        public double Diameter { get; set; }
        public string ImageUrl { get; set; }


        public static ObservableCollection<HeavenlyBody> GetHeavenlyBody()
        {
            return new ObservableCollection<HeavenlyBody>
            {
                new HeavenlyBody
                {
                    Id=2,
                    Name = "Eath",
                    Type=2,
                    Mass=5.972,
                    EMass=24,
                    Diameter=12742,
                    ImageUrl= "../images/Items/Eath.png"
                },
                new HeavenlyBody
                {
                    Id=1,
                    Name = "Sun",
                    Type=1,
                    Mass=1.989,
                    EMass=30,
                    Diameter=1391000,
                    ImageUrl= "../images/Items/Sun.png"
                },
                new HeavenlyBody
                {
                    Id=3,
                    Name = "Mars",
                    Type=2,
                    Mass=6.39,
                    EMass=23,
                    Diameter=6779,
                    ImageUrl= "../images/Items/Mars.png"
                }

            };

        }
    }
}
