﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaneuski.Casino.Model;
using Zaneuski.Casino.Model.Repository;

namespace Zaneuski.Casino.Data.Repository
{
    public class PlayerResultRepository : BaseRepository<PlayerResult>, IPlayerResultRepository
    {
        public PlayerResultRepository(CasinoContext context)
            : base(context)
        {
            
        }
    }
}
