using System.Collections.Generic;

namespace Zaneuski.Casino.Model
{
    public class TournamentRestriction : BaseUnit, IInitializer
    {
        public int MinimumNumberOfWins { get; set; }

        public int MaximumNumberOfWins { get; set; }

        public double Fee { get; set; }

        public virtual List<Tournament> Tournaments { get; set; } 

        public TournamentRestriction()
        {
            Initialize();
        }

        public TournamentRestriction(string typeCode, int minimumNumberOfWins, int maximumNumberOfWins, double fee)
        {
            Initialize();
            this.MinimumNumberOfWins = minimumNumberOfWins;
            this.MaximumNumberOfWins = maximumNumberOfWins;
            this.Fee = fee;
        }

        public void Initialize()
        {
            this.Tournaments = new List<Tournament>();
        }
    }
}
