using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaneuski.Casino.Data;
using Zaneuski.Casino.Data.Repository;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.WcfServiceLibrary
{
    public class AdministratorService : IAdministratorService
    {
        private readonly BaseRepository<Administrator> _repository;

        public AdministratorService()
        {
            this._repository = new AdministratorRepository(new CasinoContext());
        }

        public AdministratorType Get(int id)
        {
            Administrator result = this._repository.GetById(id);
            return AdministratorType.ConvertToCompositeType(result);
        }

        public IEnumerable<AdministratorType> GetAll()
        {
            List<Administrator> entries = (List<Administrator>)this._repository.GetAll();
            List<AdministratorType> result = new List<AdministratorType>();
            foreach (var item in entries)
            {
                result.Add(AdministratorType.ConvertToCompositeType(item));
            }
            return result;
        }

        public void Update(AdministratorType source)
        {
            Administrator downloadable = AdministratorType.ConvertFromCompositeType(source);
            this._repository.Update(downloadable);
            this._repository.Save();
        }

        public void Delete(int id)
        {
            this._repository.Delete(o => o.Id == id);
            this._repository.Save();
        }

        public void Add(AdministratorType source)
        {
            Administrator downloadable = AdministratorType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
