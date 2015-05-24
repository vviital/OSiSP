using System.Collections.Generic;
using Zaneuski.Casino.Data;
using Zaneuski.Casino.Data.Repository;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.WcfServiceLibrary
{
    public class RoundResultService : IRoundResultService
    {
        private readonly BaseRepository<RoundResult> _repository;

        public RoundResultService()
        {
            this._repository = new RoundResultRepository(new CasinoContext());
        }

        public RoundResultType Get(int id)
        {
            RoundResult result = this._repository.GetById(id);
            return RoundResultType.ConvertToCompositeType(result);
        }

        public IEnumerable<RoundResultType> GetAll()
        {
            List<RoundResult> entries = (List<RoundResult>)this._repository.GetAll();
            List<RoundResultType> result = new List<RoundResultType>();
            foreach (var item in entries)
            {
                result.Add(RoundResultType.ConvertToCompositeType(item));
            }
            return result;
        }

        public void Update(RoundResultType source)
        {
            RoundResult downloadable = RoundResultType.ConvertFromCompositeType(source);
            this._repository.Update(downloadable);
            this._repository.Save();
        }

        public void Delete(int id)
        {
            this._repository.Delete(o => o.Id == id);
            this._repository.Save();
        }

        public void Add(RoundResultType source)
        {
            RoundResult downloadable = RoundResultType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
