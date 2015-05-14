using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    class Round
    {
        public virtual List<Player> Participants { get; set; }

        public int RoomNumber { get; set; }

        public virtual List<RoundResult> RoundResults { get; set; }

        public virtual Tournament Tournament { get; set; }

        public int NumberOfPlayer
        {
            get { return this.RoundResults.Count; }
        }

        public Round()
        {
            
        }

        public Round(int roomNumber)
        {
            this.RoomNumber = roomNumber;
        } 
    }
}
