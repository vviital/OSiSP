using Zaneuski.Casino.Model;
using Zaneuski.Casino.Model.Repository;

namespace Zaneuski.Casino.Data.Repository
{
    public class AdministratorRepository : BaseRepository<Administrator>, IAdministratorRepository
    {
        public AdministratorRepository(CasinoContext context)
            : base(context)
        {
            
        }
    }
}
