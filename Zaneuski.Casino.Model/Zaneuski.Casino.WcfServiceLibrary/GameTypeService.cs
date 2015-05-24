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
    public class GameTypeService : IGameTypeService
    {
        private readonly BaseRepository<GameType> _repository;

        public GameTypeService()
        {
            this._repository = new GameTypeRepository(new CasinoContext());
        }

        public GameTypesType Get(int id)
        {
            GameType result = this._repository.GetById(id);
            return GameTypesType.ConvertToCompositeType(result);
        }

        public IEnumerable<GameTypesType> GetAll()
        {
            List<GameType> entries = (List<GameType>)this._repository.GetAll();
            List<GameTypesType> result = new List<GameTypesType>();
            foreach (var item in entries)
            {
                result.Add(GameTypesType.ConvertToCompositeType(item));
            }
            return result;
        }

        public void Update(GameTypesType source)
        {
            GameType downloadable = GameTypesType.ConvertFromCompositeType(source);
            this._repository.Update(downloadable);
            this._repository.Save();
        }

        public void Delete(int id)
        {
            this._repository.Delete(o => o.Id == id);
            this._repository.Save();
        }

        public void Add(GameTypesType source)
        {
            GameType downloadable = GameTypesType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
