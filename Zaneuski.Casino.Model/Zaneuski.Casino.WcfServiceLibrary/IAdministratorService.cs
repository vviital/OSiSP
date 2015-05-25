namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// IAdministratorService 
    /// </summary>
    [ServiceContract]
    public interface IAdministratorService
    {
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [OperationContract]
        AdministratorType Get(int id);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        IEnumerable<AdministratorType> GetAll();

        /// <summary>
        /// Updates the specified country type.
        /// </summary>
        /// <param name="countryType">Type of the country.</param>
        [OperationContract]
        void Update(AdministratorType countryType);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [OperationContract]
        void Delete(int id);

        /// <summary>
        /// Adds the specified country.
        /// </summary>
        /// <param name="country">The country.</param>
        [OperationContract]
        void Add(AdministratorType country);
    }

    /// <summary>
    /// AdministratorType
    /// </summary>
    [DataContract]
    public class AdministratorType
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the login.
        /// </summary>
        /// <value>
        /// The login.
        /// </value>
        [DataMember]
        public string Login { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [DataMember]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        [DataMember]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="AdministratorType"/> is sex.
        /// </summary>
        /// <value>
        ///   <c>true</c> if sex; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool Sex { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [DataMember]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the birth.
        /// </summary>
        /// <value>
        /// The birth.
        /// </value>
        [DataMember]
        public DateTime Birth { get; set; }

        /// <summary>
        /// Gets or sets the observed players.
        /// </summary>
        /// <value>
        /// The observed players.
        /// </value>
        [DataMember]
        public List<int> ObservedPlayers { get; set; }

        /// <summary>
        /// Gets or sets the supervised tournaments.
        /// </summary>
        /// <value>
        /// The supervised tournaments.
        /// </value>
        [DataMember]
        public List<int> SupervisedTournaments { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        [DataMember]
        public int Country { get; set; }

        /// <summary>
        /// Converts the type of to composite.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static AdministratorType ConvertToCompositeType(Administrator obj)
        {
            AdministratorType type = new AdministratorType()
            {
                Id = obj.Id,
                Birth = obj.Birth,
                Email = obj.Email,
                Country = obj.Country.Id,
                FirstName = obj.FirstName,
                Sex = obj.Sex,
                Login = obj.Login,
                Password = obj.Password,
                Surname = obj.Surname,
                ObservedPlayers = new List<int>(),
                SupervisedTournaments = new List<int>()
            };
            foreach (var observedPlayer in obj.ObservedPlayers)
            {
                type.ObservedPlayers.Add(observedPlayer.Id);
            }
            foreach (var supervisedTournament in obj.SupervisedTournaments)
            {
                type.SupervisedTournaments.Add(supervisedTournament.Id);
            }
            return type;
        }

        /// <summary>
        /// Converts the type of from composite.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static Administrator ConvertFromCompositeType(AdministratorType obj)
        {
            Administrator administrator = new Administrator()
            {
                Id = obj.Id,
                Birth = obj.Birth,
                Email = obj.Email,
                Login = obj.Login,
                FirstName = obj.FirstName,
                Password = obj.Password,
                Sex = obj.Sex,
                Surname = obj.Surname
            };
            return administrator;
        }
    }
}
