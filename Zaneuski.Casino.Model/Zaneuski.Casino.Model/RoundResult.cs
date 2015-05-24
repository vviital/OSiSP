namespace Zaneuski.Casino.Model
{
    public class RoundResult : BaseUnit
    {
        public virtual Round TournamentRoom { get; set; }

        public virtual Player Participant { get; set; }

        public double Gain { get; set; }

        public RoundResult()
        {

        }

        public RoundResult(Round tournamentRoom, Player participant, double gainMoney)
        {
            this.TournamentRoom = tournamentRoom;
            this.Participant = participant;
            this.Gain = gainMoney;
        }
    }
}
