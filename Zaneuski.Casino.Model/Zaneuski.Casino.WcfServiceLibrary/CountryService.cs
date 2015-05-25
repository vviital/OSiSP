using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Zaneuski.Casino.Data;
using Zaneuski.Casino.Data.Repository;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CountryService : ICountryService
    {
        private readonly BaseRepository<Country> _repository;

        public CountryService()
        {
            this._repository = new CountryRepository(new CasinoContext());
        }

        public CountryType Get(int id)
        {
            Country result = this._repository.GetById(id);
            return CountryType.ConvertToCompositeType(result);
        }

        public IEnumerable<CountryType> GetAll()
        {
            List<Country> entries = (List<Country>)this._repository.GetAll();
            List<CountryType> result = new List<CountryType>();
            foreach (var item in entries)
            {
                result.Add(CountryType.ConvertToCompositeType(item));
            }
            return result;
        }

        public void Update(CountryType source)
        {
            Country downloadable = CountryType.ConvertFromCompositeType(source);
            this._repository.Update(downloadable);
            this._repository.Save();
        }

        public void Delete(int id)
        {
            this._repository.Delete(o => o.Id == id);
            this._repository.Save();
        }

        public void Add(CountryType source)
        {
            Country downloadable = CountryType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}