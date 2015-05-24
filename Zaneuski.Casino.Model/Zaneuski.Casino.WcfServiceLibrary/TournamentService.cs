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
    class TournamentService : ITournamentService
    {
        private readonly BaseRepository<Tournament> _repository;

        public TournamentService()
        {
            this._repository = new TournamentRepository(new CasinoContext());
        }

        public TournamentType Get(int id)
        {
            Tournament result = this._repository.GetById(id);
            return TournamentType.ConvertToCompositeType(result);
        }

        public IEnumerable<TournamentType> GetAll()
        {
            List<Tournament> entries = (List<Tournament>)this._repository.GetAll();
            List<TournamentType> result = new List<TournamentType>();
            foreach (var item in entries)
            {
                result.Add(TournamentType.ConvertToCompositeType(item));
            }
            return result;
        }

        public void Update(TournamentType source)
        {
            Tournament downloadable = TournamentType.ConvertFromCompositeType(source);
            this._repository.Update(downloadable);
            this._repository.Save();
        }

        public void Delete(int id)
        {
            this._repository.Delete(o => o.Id == id);
            this._repository.Save();
        }

        public void Add(TournamentType source)
        {
            Tournament downloadable = TournamentType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
