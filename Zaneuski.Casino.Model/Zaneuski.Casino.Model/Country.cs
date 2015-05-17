using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    public class Country : BaseUnit, IInitializer
    {

        public Country()
        {

        }

        public Country(string country)
        {
            this.CountryName = country;
        }

        public void Initialize()
        {
            this.Administrators = new List<Administrator>();
            this.Players = new List<Player>();
        }

        public string CountryName { get; set; }

        public virtual List<Player> Players { get; set; }

        public virtual List<Administrator> Administrators { get; set; } 
    }
}
