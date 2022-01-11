using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetnSaltyModels
{
    public class Flavor
    {
        public int flavor_Id {get; set;}
        public string flavor_Name {get; set;}


        public Flavor(string flavor_Name)
        {
            this.flavor_Name = flavor_Name;
        }

        public Flavor()
        {
        }
    }
}
