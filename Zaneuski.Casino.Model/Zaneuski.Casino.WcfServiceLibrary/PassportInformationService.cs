using System.Collections.Generic;
using Zaneuski.Casino.Data;
using Zaneuski.Casino.Data.Repository;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.WcfServiceLibrary
{
    public class PassportInformationService : IPassportInformationService
    {
        private readonly BaseRepository<PassportInformation> _repository;

        public PassportInformationService()
        {
            this._repository = new PassportInformationRepository(new CasinoContext());
        }

        public PassportInformationType Get(int id)
        {
            PassportInformation result = this._repository.GetById(id);
            return PassportInformationType.ConvertToCompositeType(result);
        }

        public IEnumerable<PassportInformationType> GetAll()
        {
            List<PassportInformation> entries = (List<PassportInformation>)this._repository.GetAll();
            List<PassportInformationType> result = new List<PassportInformationType>();
            foreach (var item in entries)
            {
                result.Add(PassportInformationType.ConvertToCompositeType(item));
            }
            return result;
        }

        public void Update(PassportInformationType source)
        {
            PassportInformation downloadable = PassportInformationType.ConvertFromCompositeType(source);
            this._repository.Update(downloadable);
            this._repository.Save();
        }

        public void Delete(int id)
        {
            this._repository.Delete(o => o.Id == id);
            this._repository.Save();
        }

        public void Add(PassportInformationType source)
        {
            PassportInformation downloadable = PassportInformationType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
