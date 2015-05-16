using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    public class Country : BaseUnit
    {

        public Country()
        {

        }

        public Country(string country)
        {
            this.CountryName = country;
        }

        public string CountryName { get; set; }

        public virtual List<Player> Players { get; set; }

        public virtual List<Administrator> Administrators { get; set; } 
    }
}
