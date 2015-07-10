using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Zaneuski.Casino.WcfServiceLibrary;
using Zaneuski.Casino.WpfApplication.ServiceReference1;
using Zaneuski.Casino.WpfApplication.ServiceReference3;
using Zaneuski.Casino.WpfApplication.ServiceReference8;

namespace Zaneuski.Casino.WpfApplication.Model
{
    public class TournamentsModel
    {
        public int Id { get; set; }

        public string TournamentName { get; set; }

        public int NumberOfParticipants { get; set; }

        public int NumbefOfRound { get; set; }

        public string GameType { get; set; }

        public string Admin { get; set; }

        public int MinimumNumberOfWins { get; set; }

        public double Fee { get; set; }

        public TournamentsModel(TournamentType tournament)
        {
            GameTypeServiceClient gameTypeService = new GameTypeServiceClient();
            AdministratorServiceClient administratorService = new AdministratorServiceClient();
            TournamentRestrictionServiceClient restrictionServiceClient = new TournamentRestrictionServiceClient();
            Id = tournament.Id;
            TournamentName = tournament.TournamentName;
            NumberOfParticipants = tournament.ParticipantsId.Count();
            NumbefOfRound = tournament.Rounds.Count();
            GameTypesType type = gameTypeService.Get(tournament.GameTypeId);
            AdministratorType admin = administratorService.Get(tournament.AdminId);
            TournamentRestrictionType restriction = restrictionServiceClient.Get(tournament.RestrictionId);
            Admin = admin.Login;
            GameType = type.Type;
            MinimumNumberOfWins = restriction.MinimumNumberOfWins;
            Fee = restriction.Fee;
        }
    }
}
