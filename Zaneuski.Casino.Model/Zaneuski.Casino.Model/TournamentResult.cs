using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    class TournamentResult
    {
        public virtual Tournament Tournament { get; set; }

        public virtual Player Participant { get; set; }

        public Money Gain { get; set; }

        public TournamentResult()
        {
            
        }

        public TournamentResult(Tournament tournament, Player participant, Money gainMoney)
        {
            this.Tournament = tournament;
            this.Participant = participant;
            this.Gain = gainMoney;
        }
    }
}
