using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    class RoundResult : BaseUnit
    {
        public virtual Round TournamentRoom { get; set; }

        public virtual Player Participant { get; set; }

        public Money Gain { get; set; }

        public RoundResult()
        {

        }

        public RoundResult(Round tournamentRoom, Player participant, Money gainMoney)
        {
            this.TournamentRoom = tournamentRoom;
            this.Participant = participant;
            this.Gain = gainMoney;
        }
    }
}
