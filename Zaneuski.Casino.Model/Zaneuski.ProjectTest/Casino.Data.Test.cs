using System;
using System.Collections.Generic;
using System.Net.Mime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaneuski.Casino.Data;
using Zaneuski.Casino.Data.Repository;
using Zaneuski.Casino.Model;

namespace Zaneuski.ProjectTest
{
    [TestClass]
    public class CRUDtests
    {
        [TestMethod]
        public void MakeBaseTest()
        {
            //using (var context = new CasinoContext())
            {
                #region Country
                var country1 = new Country() {CountryName = "Belarus"};
                var country2 = new Country() {CountryName = "Russia"};
                #endregion

                #region Admin
                var administrator = new Administrator()
                {
                    Login = "Admin",
                    Password = "Admin",
                    Birth = new DateTime(1994, 12, 26),
                    FirstName = "Vitali",
                    Surname = "Zaneuski",
                    Email = "vviital@tut.by",
                    Country = country1,
                    Sex = true
                };
                #endregion

                #region PassportInformation
                var passport1 = new PassportInformation()
                {
                    ExpirationDate = new DateTime(2020, 2, 2),
                    Nationality = "Russian",
                    PassportNumber = "KH1234345"
                };

                var passport2 = new PassportInformation()
                {
                    ExpirationDate = new DateTime(2020, 2, 2),
                    Nationality = "Belarus",
                    PassportNumber = "KH2334433"
                };
                #endregion

                #region Users
                var user1 = new Player()
                {
                    Login = "Alex",
                    Password = "Alex_1994",
                    Birth = new DateTime(1994, 2, 11),
                    FirstName = "Alex",
                    Surname = "Kuznechov",
                    Email = "alex_kuznechov&@mail.ru",
                    Country = country2,
                    Sex = true,
                    Admin = administrator,
                    Passport = passport1,
                    VerifyFlag = false,
                    PhoneNumber = "+37533-0000-00-00",
                    AccountBalance = 42
                };

                var user2 = new Player()
                {
                    Login = "Unknown",
                    Password = "Hidfhf",
                    Birth = new DateTime(1994, 2, 11),
                    FirstName = "Unknown person",
                    Surname = "Unknown person",
                    Email = "unknown@mail.ru",
                    Country = country1,
                    Sex = false,
                    VerifyFlag = true,
                    Admin = administrator,
                    AccountBalance = 21,
                    PhoneNumber = "+37533-0000-00-01",
                    Passport = passport2
                };

                #endregion

                #region LinkPassportUser
                passport1.Player = user1;
                passport2.Player = user2;
                #endregion

                #region MakeFriend
                user1.haveFriends.Add(user2);
                user2.isFriends.Add(user1);
                user2.haveFriends.Add(user1);
                user1.isFriends.Add(user2);
                #endregion

                #region ObservedPlayers
                administrator.ObservedPlayers.Add(user1);
                administrator.ObservedPlayers.Add(user2);
                #endregion

                #region LinkCountry
                country1.Administrators.Add(administrator);
                country1.Players.Add(user1);
                country2.Players.Add(user2);
                #endregion

                #region GameType
                var gametype = new GameType()
                {
                    Type = "Texas hold'em"
                };
                #endregion

                #region Restriction
                var restriction = new TournamentRestriction()
                {
                    MinimumNumberOfWins = 0,
                    MaximumNumberOfWins = 1000,
                    Fee = 5
                };
                #endregion

                #region Tournament
                var tournament1 = new Tournament()
                {
                    GameType = gametype,
                    Schedule = new DateTime(2015, 5, 22),
                    Admin = administrator,
                    Restriction = restriction,
                    TournamentName = "Texas hold'em tournament"
                };
                #endregion

                #region LinkTournamentAndAdmin
                administrator.SupervisedTournaments.Add(tournament1);
                #endregion

                #region LinkTorunamentAndGameType
                gametype.Tournaments.Add(tournament1);
                #endregion

                #region LinkRestriction
                restriction.Tournaments.Add(tournament1);
                #endregion

                #region LinkParticipantsAndTournament
                tournament1.Participants.Add(user1);
                tournament1.Participants.Add(user2);

                user1.Tournaments.Add(tournament1);
                user2.Tournaments.Add(tournament1);
                #endregion

                #region Round
                var round = new Round()
                {
                    Tournament = tournament1,
                    RoomNumber = 1
                };
                #endregion

                #region LinkTournamentAndRound
                tournament1.Rounds.Add(round);
                #endregion

                #region RoundResult
                var roundResult1 = new RoundResult()
                {
                    Gain = 2,
                    TournamentRoom = round,
                    Participant = user1
                };

                var roundResult2 = new RoundResult()
                {
                    Gain = 3,
                    TournamentRoom = round,
                    Participant = user2
                };

                user1.RoundResults.Add(roundResult1);
                user2.RoundResults.Add(roundResult2);
                round.RoundResults.Add(roundResult1);
                round.RoundResults.Add(roundResult2);

                #endregion

                using (var context = new CasinoContext())
                {
                    BaseRepository<Player> players = new PlayerRepository(context);
                    BaseRepository<Administrator> admin = new AdministratorRepository(context);
                    BaseRepository<Tournament> tournament = new TournamentRepository(context);
                    BaseRepository<TournamentRestriction> tRestriction = new TournamentRestrictionRepository(context);
                    BaseRepository<Round> rounds = new RoundRepository(context);
                    BaseRepository<RoundResult> rResults = new RoundResultRepository(context);
                    BaseRepository<GameType> gType = new GameTypeRepository(context);
                    BaseRepository<Country> country = new CountryRepository(context);
                    BaseRepository<PassportInformation> passports = new PassportInformationRepository(context);

                    country.Add(country1);
                   // players.Add(user1);

                    int num = 0;
                    num++;
                    players.Save();
                }
            }
        }
    }
}
