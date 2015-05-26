namespace Zaneuski.ProjectTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Zaneuski.Casino.Data;
    using Zaneuski.Casino.Data.Repository;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// Create Read Update Delete database tests
    /// </summary>
    [TestClass]
    public class CRUDtests
    {
        /// <summary>
        /// Makes the base test.
        /// </summary>
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

                if (admins.GetAll() == null || admins.GetAll().Count() == 0)
                {
                    admins.Add(admin);
                    admins.Save();
                }
            }
            Assert.AreEqual(true, true);
        }

        /// <summary>
        /// Makes the single add delete test.
        /// </summary>
        [TestMethod]
        public void MakeSingleAddDeleteTest()
        {
            Country country = new Country() {CountryName = "USA"};
            bool good = false;
            using (var context = new CasinoContext())
            {
                BaseRepository<Country> countries = new CountryRepository(context);
                int oldCount = countries.Count(o => o.CountryName != null);
                countries.Add(country);
                countries.Save();
                int newCount = countries.Count(o => o.CountryName != null);
                if (newCount - 1 == oldCount)
                {
                    good = true;
                }
                Country entity = countries.Get(o => o.CountryName.CompareTo("USA") == 0);
                countries.Delete(entity);
                countries.Save();
            }
            Assert.AreEqual(true, good);
        }

        /// <summary>
        /// Makes the update test.
        /// </summary>
        [TestMethod]
        public void MakeUpdateTest()
        {
            bool good = false;
            using (var context = new CasinoContext())
            {
                BaseRepository<Administrator> admins = new AdministratorRepository(context);
                Administrator admin = admins.Get(o => o.FirstName == "Vitali");
                admin.FirstName = "vitali";
                admins.Update(admin);
                admins.Save();
                admin = admins.Get(o => o.FirstName == "vitali");
                if (admin.FirstName.CompareTo("vitali") == 0)
                {
                    good = true;
                }
                admin.FirstName = "Vitali";
                admins.Update(admin);
                admins.Save();
            }
            Assert.AreEqual(true, good);
        }

        /// <summary>
        /// Makes the multiple delete test.
        /// </summary>
        [TestMethod]
        public void MakeMultipleDeleteTest()
        {
            bool good = true;
            using (var context = new CasinoContext())
            {
                GameType type1 = new GameType(){Type = "New Type1"};
                GameType type2 = new GameType() {Type = "New Type2"};

                BaseRepository<GameType> gameTypes = new GameTypeRepository(context);

                int oldCount = gameTypes.GetAll().Count();

                gameTypes.Add(type1);
                gameTypes.Add(type2);
                gameTypes.Save();

                //Work
                //List<GameType> games = (List<GameType>)gameTypes.GetMany(o => o.Type == "New Type1");
                int newCount = gameTypes.GetAll().Count();

                if (newCount - 2 != oldCount)
                {
                    good = false;
                }

                // didn't work!!!
                //Func<GameType, bool> predicateCheckName = o =>
                //{
                //    return true;
                //    string templ = "New Type";
                //    if (o.Type.Count() < templ.Count()) return false;
                //    bool ok = true;
                //    for(int iter = 0; iter < templ.Count(); iter++)
                //        if (templ[iter].CompareTo(o.Type[iter]) != 0)
                //            ok = false;
                //    return ok;
                //};
                //gameTypes.Delete(o => predicateCheckName(o));

                gameTypes.Delete(o => o.Type == "New Type1" || o.Type == "New Type2");
                gameTypes.Save();
                if (gameTypes.GetAll().Count() != oldCount)
                {
                    good = false;
                }
            }
            Assert.AreEqual(true, good);
        }

        /// <summary>
        /// Makes the get by identifier test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void MakeGetByIdTest()
        {
            using (var context = new CasinoContext())
            {
                BaseRepository<Administrator> admins = new AdministratorRepository(context);
                int invalidID = Int32.MaxValue;
                Administrator administrator = admins.GetById(invalidID);
                bool check = administrator.Id.CompareTo(invalidID) == 0;
                Assert.AreEqual(true, false);
            }
        }

        /// <summary>
        /// Makes the get all test.
        /// </summary>
        [TestMethod]
        public void MakeGetAllTest()
        {
            using (var context = new CasinoContext())
            {
                BaseRepository<Administrator> admins = new AdministratorRepository(context);
                List<Administrator> administrators = (List<Administrator>)admins.GetAll();
                Assert.AreEqual(1, administrators.Count());
            }
        }

        /// <summary>
        /// Makes the get many test.
        /// </summary>
        [TestMethod]
        public void MakeGetManyTest()
        {
            bool good = true;
            using (var context = new CasinoContext())
            {
                BaseRepository<Player> players = new PlayerRepository(context);
                
                List<Player> players_query_1 = (List<Player>)players.GetMany(o => o.Sex);
                List<Player> players_query_2 = (List<Player>) players.GetMany(o => o.Admin.FirstName == "Vitali");

                if (players_query_1.Count() != 2)
                {
                    good = false;
                }

                if (players_query_2.Count() != 2)
                {
                    good = false;
                }
            }
            Assert.AreEqual(true, good);
        }

        /// <summary>
        /// Makes the get test.
        /// </summary>
        [TestMethod]
        public void MakeGetTest()
        {
            bool good = true;
            using (var context = new CasinoContext())
            {
                BaseRepository<Tournament> tournaments = new TournamentRepository(context);

                //http://www.cyberforum.ru/csharp-net/thread1374178.html
                // Doesn't work
                //Func<Tournament, bool> filter = o => o.GameType.Type == "Texas hold 'em";

                //Tournament tournament = tournaments.Get(o => filter(o));

                Tournament tournament = tournaments.Get(o => o.GameType.Type == "Texas hold 'em");

                if (tournament.TournamentName == null)
                    good = false;
            }
            Assert.AreEqual(true, good);
        }

        /// <summary>
        /// Makes the count test.
        /// </summary>
        [TestMethod]
        public void MakeCountTest()
        {
            bool good = true;
            using (var context = new CasinoContext())
            {
                BaseRepository<TournamentRestriction> repository = new TournamentRestrictionRepository(context);

                int count = repository.Count(o => o.Id == 0 || o.Id != 0);

                if (count != repository.GetAll().Count())
                {
                    good = false;
                }
            }
            Assert.AreEqual(true, good);
        }

        /// <summary>
        /// Makes the is exist test.
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        [TestMethod]
        public void MakeIsExistTest()
        {
            using (var context = new CasinoContext())
            {
                BaseRepository<Administrator> admins = new AdministratorRepository(context);

                //Func<BaseUnit, bool> filter = o => o.Id == 0 || o.Id != 0;
                Administrator admin = admins.Get(o => o.Id == 0 || o.Id != 0);

                if (admin == null) throw new Exception();

                Assert.AreEqual(true, admins.IsExist(o => o.Id == 0 || o.Id != 0));
            }
        }
    }
}
