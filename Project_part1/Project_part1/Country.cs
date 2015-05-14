using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part1
{
    class Country
    {

        public Country()
        {
            
        }

        public Country(string countrycode, string country)
        {
            this.CountryCode = countrycode;
            this.CountryName = country;
        }

        public string CountryCode { get; set; }

        public string CountryName { get; set; }
    }
}
