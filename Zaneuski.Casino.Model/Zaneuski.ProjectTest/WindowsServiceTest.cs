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
        private readonly AdministratorServiceClient _adminServiceClient = new AdministratorServiceClient();
        private readonly PlayerServiceClient _playerServiceClient = new PlayerServiceClient();
        private readonly TournamentServiceClient _tournamentServiceClient = new TournamentServiceClient();
        private readonly TournamentRestrictionServiceClient _tournamentRestrictionServiceClient =
                            new TournamentRestrictionServiceClient();
        private readonly RoundServiceClient _roundServiceClient = new RoundServiceClient();
        private readonly RoundResultServiceClient _roundResultServiceClient = new RoundResultServiceClient();
        private readonly GameTypeServiceClient _gameTypeServiceClient = new GameTypeServiceClient();
        private readonly PassportInformationServiceClient _passportInformationServiceClient = new PassportInformationServiceClient();
        private readonly CountryServiceClient _countryServiceClient = new CountryServiceClient();

        /// <summary>
        /// Tests the getAll methods.
        /// </summary>
        [TestMethod]
        public void TestGetAllMethods()
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
    }
}
