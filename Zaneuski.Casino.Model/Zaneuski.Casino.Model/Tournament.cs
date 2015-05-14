using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    class Tournament
    {
        public virtual GameType GameType { get; set; }

        public virtual List<Player> Participants { get; set; }

        public virtual Administrator Admin { get; set; }

        public virtual TournamentRestriction Restriction { get; set; }

        public string TournamentName { get; set; }

        public DateTime Schedule { get; set; }

        public List<Round> Rounds { get; set; }

        public int NumberOfPerticipants
        {
            get { return this.Participants.Count; }
        }

        public Tournament()
        {
            
        }

        public Tournament(GameType gameType, List<Player> participants, Administrator administrator,
            TournamentRestriction restriction, string tournamentName, DateTime schedule, List<Round> rounds)
        {
            this.GameType = gameType;
            this.Participants = participants;
            this.Admin = administrator;
            this.Restriction = restriction;
            this.TournamentName = tournamentName;
            this.Schedule = schedule;
            this.Rounds = rounds;
        }
    }
}
