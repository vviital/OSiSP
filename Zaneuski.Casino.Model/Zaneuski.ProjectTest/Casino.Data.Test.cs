using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            var admin = new Administrator()
            {
                Login = "Admin", Password = "Admin", FirstName = "Vitali", Surname = "Zaneuski",
                Email = "vviital@tut.by", Sex = true, Birth = new DateTime(1994, 12, 26)
            };

            var player1 = new Player()
            {
                Login = "p1", Password = "123", FirstName = "f1", Surname = "s1", 
                Email = "p1@mail.ru", Admin = admin, PhoneNumber = "1234556", Sex = true, VerifyFlag = false,
                Birth = new DateTime(1994, 1, 1), AccountBalance = 42
            };
            var player2 = new Player()
            {
                Login = "p2", Password = "123", FirstName = "f2", Surname = "s2",
                Email = "p2@mail.ru", Admin = admin, PhoneNumber = "12340000", Sex = true, VerifyFlag = true,
                Birth = new DateTime(1994, 1, 1), AccountBalance = 42
            };

            var tournament = new Tournament()
            {
                Admin = admin, Schedule = new DateTime(2015, 5, 30), TournamentName = "Poker tournament"
            };

            var round = new Round() {Tournament = tournament, RoomNumber = 1};

            var roundResult1 = new RoundResult() {Gain = 24, Participant = player1, TournamentRoom = round};
            var roundResult2 = new RoundResult() {Gain = 33, Participant = player2, TournamentRoom = round};

            var country1 = new Country() {CountryName = "Belarus"};
            var country2 = new Country() {CountryName = "Russia"};

            var tournamentRestriction = new TournamentRestriction() {Fee = 5, MinimumNumberOfWins = 0};

            var passport1 = new PassportInformation() { ExpirationDate = new DateTime(2020, 1, 1), Player = player1, Nationality = "Belarus", PassportNumber = "KH12344546"};
            var passport2 = new PassportInformation() { ExpirationDate = new DateTime(2020, 1, 1), Player = player2, Nationality = "Belarus", PassportNumber = "KH45456233"};

            var gameType = new GameType() { Type = "Texas hold 'em" };

            admin.ObservedPlayers.Add(player1);
            admin.ObservedPlayers.Add(player2);
            admin.Country = country1;
            admin.SupervisedTournaments.Add(tournament);

            player1.Passport = passport1;
            player1.RoundResults.Add(roundResult1);
            player1.Tournaments.Add(tournament);
            player1.haveFriends.Add(player2);
            player1.isFriends.Add(player2);
            player1.Country = country1;

            player2.Passport = passport2;
            player2.RoundResults.Add(roundResult2);
            player2.Tournaments.Add(tournament);
            player2.haveFriends.Add(player1);
            player2.isFriends.Add(player1);
            player2.Country = country2;

            tournament.Participants.Add(player1);
            tournament.Participants.Add(player2);
            tournament.Restriction = tournamentRestriction;
            tournament.Rounds.Add(round);
            tournament.GameType = gameType;

            round.RoundResults.Add(roundResult1);
            round.RoundResults.Add(roundResult2);

            country1.Players.Add(player1);
            country1.Administrators.Add(admin);

            country2.Players.Add(player2);

            tournamentRestriction.Tournaments.Add(tournament);

            gameType.Tournaments.Add(tournament);

            using (var context = new CasinoContext())
            {
                BaseRepository<Player> players = new PlayerRepository(context);
                BaseRepository<Administrator> admins = new AdministratorRepository(context);
                BaseRepository<Tournament> tournaments = new TournamentRepository(context);
                BaseRepository<TournamentRestriction> tRestrictions = new TournamentRestrictionRepository(context);
                BaseRepository<Round> rounds = new RoundRepository(context);
                BaseRepository<RoundResult> rResults = new RoundResultRepository(context);
                BaseRepository<GameType> gTypes = new GameTypeRepository(context);
                BaseRepository<Country> countries = new CountryRepository(context);
                BaseRepository<PassportInformation> passports = new PassportInformationRepository(context);

                admins.Add(admin);
                players.Add(player1);

                int num = 0;
                num++;
            }
        }
    }
}
