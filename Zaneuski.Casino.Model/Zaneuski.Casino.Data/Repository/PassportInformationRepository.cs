using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaneuski.Casino.Model;
using Zaneuski.Casino.Model.Repository;

namespace Zaneuski.Casino.Data.Repository
{
    public class PassportInformationRepository : BaseRepository<PassportInformation>, IPassportInformationRepository
    {
        public PassportInformationRepository(CasinoContext context) 
            : base(context)
        {
            
        }
    }
}
