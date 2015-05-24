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
    class PlayerService : IPlayerService
    {
        private readonly BaseRepository<Player> _repository;

        public PlayerService()
        {
            this._repository = new PlayerRepository(new CasinoContext());
        }

        public PlayerType Get(int id)
        {
            Player result = this._repository.GetById(id);
            return PlayerType.ConvertToCompositeType(result);
        }

        public IEnumerable<PlayerType> GetAll()
        {
            List<Player> entries = (List<Player>)this._repository.GetAll();
            List<PlayerType> result = new List<PlayerType>();
            foreach (var item in entries)
            {
                result.Add(PlayerType.ConvertToCompositeType(item));
            }
            return result;
        }

        public void Update(PlayerType source)
        {
            Player downloadable = PlayerType.ConvertFromCompositeType(source);
            this._repository.Update(downloadable);
            this._repository.Save();
        }

        public void Delete(int id)
        {
            this._repository.Delete(o => o.Id == id);
            this._repository.Save();
        }

        public void Add(PlayerType source)
        {
            Player downloadable = PlayerType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
