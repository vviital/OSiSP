using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    public class TournamentRestriction : BaseUnit
    {
        public int MinimumNumberOfWins { get; set; }

        public int MaximumNumberOfWins { get; set; }

        public double Fee { get; set; }

        public virtual List<Tournament> Tournaments { get; set; } 

        public TournamentRestriction()
        {

        }

        public TournamentRestriction(string typeCode, int minimumNumberOfWins, int maximumNumberOfWins, double fee)
        {
            this.MinimumNumberOfWins = minimumNumberOfWins;
            this.MaximumNumberOfWins = maximumNumberOfWins;
            this.Fee = fee;
        }
    }
}
