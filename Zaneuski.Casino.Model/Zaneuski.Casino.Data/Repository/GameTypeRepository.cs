using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaneuski.Casino.Model;
using Zaneuski.Casino.Model.Repository;

namespace Zaneuski.Casino.Data.Repository
{
    public class GameTypeRepository : BaseRepository<GameType>, IGameTypeRepository
    {
        public GameTypeRepository(CasinoContext context)
            :   base(context)
        {
            
        }
    }
}
