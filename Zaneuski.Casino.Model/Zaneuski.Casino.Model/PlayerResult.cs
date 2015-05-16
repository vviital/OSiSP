using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    public class PlayerResult : BaseUnit
    {
        public virtual Player Player { get; set; }

        public double GainMoney { get; set; }

        public virtual GameType GameType { get; set; }

        public int NumberOfWins { get; set; }

        public int NumberOfGames { get; set; }

        public PlayerResult()
        {

        }

        public PlayerResult(Player player, double gainMoney, GameType gameType, int numberOfWins, int numberOfGames)
        {
            this.Player = player;
            this.GainMoney = gainMoney;
            this.GameType = gameType;
            this.NumberOfWins = numberOfWins;
            this.NumberOfGames = numberOfGames;
        }
    }
}
