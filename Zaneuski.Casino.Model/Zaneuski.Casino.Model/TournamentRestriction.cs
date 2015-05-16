using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    public class TournamentRestriction : BaseUnit
    {
        public string TypeCode { get; set; }

        public int MinimumNumberOfWins { get; set; }

        public int MaximumNumberOfWins { get; set; }

        public double Fee { get; set; }

        public TournamentRestriction()
        {

        }

        public TournamentRestriction(string typeCode, int minimumNumberOfWins, int maximumNumberOfWins, double fee)
        {
            this.TypeCode = typeCode;
            this.MinimumNumberOfWins = minimumNumberOfWins;
            this.MaximumNumberOfWins = maximumNumberOfWins;
            this.Fee = fee;
        }
    }
}
