using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
