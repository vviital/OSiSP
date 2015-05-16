using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Zaneuski.Casino.Model;
using Zaneuski.Casino.Model.Repository;

namespace Zaneuski.Casino.Data.Repository
{
    public class TournamentResultRepository : BaseRepository<TournamentResult>, ITournamentResultRepository
    {
        public TournamentResultRepository(CasinoContext context)
            : base(context)
        {
            
        }
    }
}
