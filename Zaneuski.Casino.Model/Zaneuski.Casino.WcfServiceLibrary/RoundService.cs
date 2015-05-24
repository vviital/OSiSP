using System.Collections.Generic;
using Zaneuski.Casino.Data;
using Zaneuski.Casino.Data.Repository;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.WcfServiceLibrary
{
    public class RoundService : IRoundService
    {
        private readonly BaseRepository<Round> _repository;

        public RoundService()
        {
            this._repository = new RoundRepository(new CasinoContext());
        }

        public RoundType Get(int id)
        {
            Round result = this._repository.GetById(id);
            return RoundType.ConvertToCompositeType(result);
        }

        public IEnumerable<RoundType> GetAll()
        {
            List<Round> entries = (List<Round>)this._repository.GetAll();
            List<RoundType> result = new List<RoundType>();
            foreach (var item in entries)
            {
                result.Add(RoundType.ConvertToCompositeType(item));
            }
            return result;
        }

        public void Update(RoundType source)
        {
            Round downloadable = RoundType.ConvertFromCompositeType(source);
            this._repository.Update(downloadable);
            this._repository.Save();
        }

        public void Delete(int id)
        {
            this._repository.Delete(o => o.Id == id);
            this._repository.Save();
        }

        public void Add(RoundType source)
        {
            Round downloadable = RoundType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
