using System;
using System.Collections.Generic;
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
                var country1 = new Country() {CountryName = "Belarus"};
                var country2 = new Country() {CountryName = "Russia"};
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

                user1.Friends.Add(user2);
                user2.Friends.Add(user1);
                
                administrator.ObservedPlayers.Add(user1);
                administrator.ObservedPlayers.Add(user2);

                country1.Administrators.Add(administrator);
                country1.Players.Add(user1);
                country2.Players.Add(user2);

                var gametype = new GameType()
                {
                    Type = "Texas hold'em"
                };

                var restriction = new TournamentRestriction()
                {
                    MinimumNumberOfWins = 0,
                    MaximumNumberOfWins = 1000,
                    Fee = 5
                };

                var tournament1 = new Tournament()
                {
                    GameType = gametype,
                    Schedule = new DateTime(2015, 5, 22),
                    Admin = administrator,
                    Restriction = restriction,
                    TournamentName = "Texas hold'em tournament"
                };

                tournament1.Participants.Add(user1);
                tournament1.Participants.Add(user2);

                user1.Tournaments.Add(tournament1);
                user2.Tournaments.Add(tournament1);

                var round = new Round()
                {
                    Tournament = tournament1,
                    RoomNumber = 1
                };

                tournament1.Rounds.Add(round);

            }
        }
    }
}
