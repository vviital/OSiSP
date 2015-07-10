using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Zaneuski.Casino.WcfServiceLibrary;
using Zaneuski.Casino.WpfApplication.ServiceReference6;

namespace Zaneuski.Casino.WpfApplication.Model
{
    public class PlayerResultModel
    {
        public int Id { get; set; }

        public string PlayerLogin { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public double TotalGain { get; set; }

        public int NumberOfRound { get; set; }

        public PlayerResultModel()
        {
            
        }

        public PlayerResultModel(PlayerType player)
        {
            RoundResultServiceClient client = new RoundResultServiceClient();
            List<RoundResultType> list = client.GetAll().ToList();
            TotalGain = 0;
            NumberOfRound = 0;
            foreach (var item in list)
            {
                if (item.ParticipantId == player.Id)
                {
                    TotalGain += item.Gain;
                    NumberOfRound++;
                }
            }
            PlayerLogin = player.Login;
            FirstName = player.FirstName;
            Surname = player.Surname;
            Id = player.Id;
        }
    }
}
