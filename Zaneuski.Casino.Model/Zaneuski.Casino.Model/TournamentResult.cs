using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    public class TournamentResult : BaseUnit
    {
        public virtual Tournament Tournament { get; set; }

        public virtual Player Participant { get; set; }

        public double Gain { get; set; }

        public TournamentResult()
        {

        }

        public TournamentResult(Tournament tournament, Player participant, double gainMoney)
        {
            this.Tournament = tournament;
            this.Participant = participant;
            this.Gain = gainMoney;
        }
    }
}
