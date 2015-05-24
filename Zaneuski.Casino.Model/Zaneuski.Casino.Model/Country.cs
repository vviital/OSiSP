using System.Collections.Generic;

namespace Zaneuski.Casino.Model
{
    public class Country : BaseUnit, IInitializer
    {

        public Country()
        {
            Initialize();
        }

        public Country(string country)
        {
            Initialize();
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
