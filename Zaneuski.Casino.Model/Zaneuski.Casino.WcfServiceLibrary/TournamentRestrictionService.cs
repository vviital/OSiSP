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
    public class TournamentRestrictionService : ITournamentRestrictionService
    {
        private readonly BaseRepository<TournamentRestriction> _repository;

        public TournamentRestrictionService()
        {
            this._repository = new TournamentRestrictionRepository(new CasinoContext());
        }

        public TournamentRestrictionType Get(int id)
        {
            TournamentRestriction result = this._repository.GetById(id);
            return TournamentRestrictionType.ConvertToCompositeType(result);
        }

        public IEnumerable<TournamentRestrictionType> GetAll()
        {
            List<TournamentRestriction> entries = (List<TournamentRestriction>)this._repository.GetAll();
            List<TournamentRestrictionType> result = new List<TournamentRestrictionType>();
            foreach (var item in entries)
            {
                result.Add(TournamentRestrictionType.ConvertToCompositeType(item));
            }
            return result;
        }

        public void Update(TournamentRestrictionType source)
        {
            TournamentRestriction downloadable = TournamentRestrictionType.ConvertFromCompositeType(source);
            this._repository.Update(downloadable);
            this._repository.Save();
        }

        public void Delete(int id)
        {
            this._repository.Delete(o => o.Id == id);
            this._repository.Save();
        }

        public void Add(TournamentRestrictionType source)
        {
            TournamentRestriction downloadable = TournamentRestrictionType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
