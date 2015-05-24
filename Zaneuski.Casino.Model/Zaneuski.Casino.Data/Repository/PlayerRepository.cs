using Zaneuski.Casino.Model;
using Zaneuski.Casino.Model.Repository;

namespace Zaneuski.Casino.Data.Repository
{
    public class PlayerRepository : BaseRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(CasinoContext context)
            : base(context)
        {
            
        }
    }
}
