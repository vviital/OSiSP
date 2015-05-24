using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Zaneuski.Casino.Data;
using Zaneuski.Casino.Data.Repository;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.WCF.Library
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CountryService : ICountryService
    {
        private CasinoContext context;
        private BaseRepository<Country> countriesRepository;

        public CountryService()
        {
            this.context = new CasinoContext();
            this.countriesRepository = new CountryRepository(context);
        }

        public CountryType Get(int id)
        {
            Country country = this.countriesRepository.GetById(id);
            return TranslateCountryToCountryType(country);
        }

        public IEnumerable<CountryType> GetAll()
        {
            List<Country> countries = (List<Country>)this.countriesRepository.GetAll();
            List<CountryType> result = new List<CountryType>();
            foreach (var country in countries)
            {
                result.Add(TranslateCountryToCountryType(country));
            }
            return result;
        }

        public void Update(CountryType countryType)
        {
            Country country = TranslateCountryTypeToCountry(countryType);
            this.countriesRepository.Update(country);
            this.countriesRepository.Save();
        }

        public void Delete(int id)
        {
            this.countriesRepository.Delete(o => o.Id == id);
            this.countriesRepository.Save();
        }

        public void Add(CountryType countryType)
        {
            Country country = TranslateCountryTypeToCountry(countryType);
            this.countriesRepository.Add(country);
            this.countriesRepository.Save();
        }

        private CountryType TranslateCountryToCountryType(Country obj)
        {
            CountryType country = new CountryType() { CountryName = obj.CountryName, Id = obj.Id };
            return country;
        }

        private Country TranslateCountryTypeToCountry(CountryType countryType)
        {
            Country country = new Country(){Id = countryType.Id, CountryName = countryType.CountryName};
            return country;
        }
    }
}
