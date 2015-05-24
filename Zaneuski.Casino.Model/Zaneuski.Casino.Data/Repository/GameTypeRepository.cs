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
