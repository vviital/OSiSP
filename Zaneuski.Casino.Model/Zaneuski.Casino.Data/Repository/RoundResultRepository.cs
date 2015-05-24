using Zaneuski.Casino.Model;
using Zaneuski.Casino.Model.Repository;

namespace Zaneuski.Casino.Data.Repository
{
    public class RoundResultRepository : BaseRepository<RoundResult>, IRoundResultRepository
    {
        public RoundResultRepository(CasinoContext context)
            : base(context)
        {
            
        }
    }
}
