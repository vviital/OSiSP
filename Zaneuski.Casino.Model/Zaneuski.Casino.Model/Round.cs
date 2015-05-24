using System.Collections.Generic;

namespace Zaneuski.Casino.Model
{
    public class Round : BaseUnit, IInitializer
    {
        public int RoomNumber { get; set; }

        public virtual List<RoundResult> RoundResults { get; set; }

        public virtual Tournament Tournament { get; set; }

        public Round()
        {
            Initialize();
        }

        public Round(int roomNumber)
        {
            Initialize();
            this.RoomNumber = roomNumber;
        }

        public void Initialize()
        {
            this.RoundResults = new List<RoundResult>();
        }
    }
}
