using Zaneuski.Casino.Model;
using Zaneuski.Casino.Model.Repository;

namespace Zaneuski.Casino.Data.Repository
{
    public class TournamentRestrictionRepository : BaseRepository<TournamentRestriction>, ITournamentRestrictionRepository
    {
        public TournamentRestrictionRepository(CasinoContext context)
            : base(context)
        {
            
        }
    }
}
