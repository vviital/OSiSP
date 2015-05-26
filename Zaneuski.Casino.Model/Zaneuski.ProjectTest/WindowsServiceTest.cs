using System.ServiceModel;
using System.Threading;

namespace Zaneuski.ProjectTest
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Policy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Zaneuski.Casino.Model;
    using Zaneuski.Casino.WcfServiceLibrary;
    using Zaneuski.ProjectTest.ServiceReference1;
    using Zaneuski.ProjectTest.ServiceReference2;
    using Zaneuski.ProjectTest.ServiceReference3;
    using Zaneuski.ProjectTest.ServiceReference4;
    using Zaneuski.ProjectTest.ServiceReference5;
    using Zaneuski.ProjectTest.ServiceReference6;
    using Zaneuski.ProjectTest.ServiceReference7;
    using Zaneuski.ProjectTest.ServiceReference8;
    using Zaneuski.ProjectTest.ServiceReference9;

    /// <summary>
    /// Summary description for WindowsServiceTest
    /// </summary>
    [TestClass]
    public class WindowsServiceTest
    {
        /// <summary>
        /// The admin service client
        /// </summary>
        private readonly AdministratorServiceClient _adminServiceClient = new AdministratorServiceClient();

        /// <summary>
        /// The player service client
        /// </summary>
        private readonly PlayerServiceClient _playerServiceClient = new PlayerServiceClient();

        /// <summary>
        /// The tournament service client
        /// </summary>
        private readonly TournamentServiceClient _tournamentServiceClient = new TournamentServiceClient();

        /// <summary>
        /// The tournament restriction service client
        /// </summary>
        private readonly TournamentRestrictionServiceClient _tournamentRestrictionServiceClient =
                            new TournamentRestrictionServiceClient();

        /// <summary>
        /// The round service client
        /// </summary>
        private readonly RoundServiceClient _roundServiceClient = new RoundServiceClient();

        /// <summary>
        /// The round result service client
        /// </summary>
        private readonly RoundResultServiceClient _roundResultServiceClient = new RoundResultServiceClient();

        /// <summary>
        /// The game type service client
        /// </summary>
        private readonly GameTypeServiceClient _gameTypeServiceClient = new GameTypeServiceClient();

        /// <summary>
        /// The passport information service client
        /// </summary>
        private readonly PassportInformationServiceClient _passportInformationServiceClient = new PassportInformationServiceClient();

        /// <summary>
        /// The country service client
        /// </summary>
        private readonly CountryServiceClient _countryServiceClient = new CountryServiceClient();

        /// <summary>
        /// Tests the getAll methods.
        /// </summary>
        [TestMethod]
        public void TestGetAllServicesMethod()
        {
            bool good = true;

            AdministratorType[] administrator = this._adminServiceClient.GetAll();

            good &= administrator != null && administrator.Count() != 0;

            PlayerType[] player = this._playerServiceClient.GetAll();

            good &= player != null && player.Count() != 0;

            PassportInformationType[] passportInformationType = this._passportInformationServiceClient.GetAll();

            good &= passportInformationType != null && passportInformationType.Count() != 0;

            CountryType[] country = this._countryServiceClient.GetAll();

            good &= country != null && country.Count() != 0;

            GameTypesType[] typesType = this._gameTypeServiceClient.GetAll();

            good &= typesType != null && typesType.Count() != 0;

            RoundResultType[] roundResultType = this._roundResultServiceClient.GetAll();

            good &= roundResultType != null && roundResultType.Count() != 0;

            RoundType[] roundType = this._roundServiceClient.GetAll();

            good &= roundType != null && roundType.Count() != 0;

            TournamentType[] tournamentType = this._tournamentServiceClient.GetAll();

            good &= tournamentType != null && tournamentType.Count() != 0;

            TournamentRestrictionType[] tournamentRestrictionType = this._tournamentRestrictionServiceClient.GetAll();

            good &= tournamentRestrictionType != null && tournamentRestrictionType.Count() != 0;

            Assert.AreEqual(true, good);
        }

        /// <summary>
        /// Tests the get by identifier services method.
        /// </summary>
        [TestMethod]
        public void TestGetByIdServicesMethod()
        {
            bool good = true;
            AdministratorType[] administrators = this._adminServiceClient.GetAll();

            List<int> playersId = administrators[0].ObservedPlayers;

            good = playersId.Any();

            foreach (var player in playersId)
            {
                PlayerType casinoPlayer = this._playerServiceClient.Get(player);
                if (casinoPlayer.Admin != administrators[0].Id)
                    good = false;
            }
            Assert.AreEqual(true, good);
        }

        /// <summary>
        /// Negatives the test get by identifier method.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void NegativeTestGetByIdMethod()
        {
            int id = Int32.MaxValue;
            AdministratorType administrator = this._adminServiceClient.Get(id);
            Assert.AreEqual(true, false);
        }

        /// <summary>
        /// Tests the add and delete services method.
        /// </summary>
        [TestMethod]
        public void TestAddAndDeleteServicesMethod()
        {
            bool good = true;

            CountryType country = new CountryType(){CountryName = "SomeFakeCountry"};

            int oldCount = this._countryServiceClient.GetAll().Count();

            this._countryServiceClient.Add(country);

            List<CountryType> countries = this._countryServiceClient.GetAll().ToList();
            int newCount = countries.Count();

            if (oldCount + 1 != newCount)
            {
                good = false;
            }

            int id = -1;

            foreach (var item in countries)
            {
                if (item.CountryName.Equals("SomeFakeCountry"))
                {
                    id = item.Id;
                }
            }

            this._countryServiceClient.Delete(id);

            newCount = this._countryServiceClient.GetAll().Count();

            if (oldCount != newCount)
            {
                good = false;
            }

            Assert.AreEqual(true, good);
        }

        /// <summary>
        /// Tests the update and delete services method.
        /// </summary>
        [TestMethod]
        public void TestUpdateAndDeleteServicesMethod()
        {
            bool good = true;

            CountryType[] countries = this._countryServiceClient.GetAll();

            string oldName = countries[0].CountryName;

            countries[0].CountryName = oldName + " Federation";

            this._countryServiceClient.Update(countries[0]);

            CountryType[] countriesUpdate = this._countryServiceClient.GetAll();

            if (!countriesUpdate[0].CountryName.Equals(oldName + " Federation"))
            {
                good = false;
            }

            countriesUpdate[0].CountryName = oldName;

            this._countryServiceClient.Update(countriesUpdate[0]);

            countriesUpdate = this._countryServiceClient.GetAll();

            if (!countriesUpdate[0].CountryName.Equals(oldName))
            {
                good = false;
            }

            Assert.AreEqual(true, good);
        }
    }
}
