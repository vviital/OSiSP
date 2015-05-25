namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// IPlayerService
    /// </summary>
    [ServiceContract]
    public interface IPlayerService
    {
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [OperationContract]
        PlayerType Get(int id);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        IEnumerable<PlayerType> GetAll();

        /// <summary>
        /// Updates the specified country type.
        /// </summary>
        /// <param name="countryType">Type of the country.</param>
        [OperationContract]
        void Update(PlayerType countryType);

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
        void Add(PlayerType country);
    }

    /// <summary>
    /// PlayerType
    /// </summary>
    [DataContract]
    public class PlayerType
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
        /// Gets or sets a value indicating whether this <see cref="PlayerType"/> is sex.
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
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        [DataMember]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the account balance.
        /// </summary>
        /// <value>
        /// The account balance.
        /// </value>
        [DataMember]
        public double AccountBalance { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [verify flag].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [verify flag]; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool VerifyFlag { get; set; }

        /// <summary>
        /// Gets or sets the is friends.
        /// </summary>
        /// <value>
        /// The is friends.
        /// </value>
        [DataMember]
        public List<int> IsFriends { get; set; }

        /// <summary>
        /// Gets or sets the have friends.
        /// </summary>
        /// <value>
        /// The have friends.
        /// </value>
        [DataMember]
        public List<int> HaveFriends { get; set; }

        /// <summary>
        /// Gets or sets the admin.
        /// </summary>
        /// <value>
        /// The admin.
        /// </value>
        [DataMember]
        public int Admin { get; set; }

        /// <summary>
        /// Gets or sets the tournaments.
        /// </summary>
        /// <value>
        /// The tournaments.
        /// </value>
        [DataMember]
        public List<int> Tournaments { get; set; }

        /// <summary>
        /// Gets or sets the passport.
        /// </summary>
        /// <value>
        /// The passport.
        /// </value>
        [DataMember]
        public int Passport { get; set; }

        /// <summary>
        /// Gets or sets the round results.
        /// </summary>
        /// <value>
        /// The round results.
        /// </value>
        [DataMember]
        public List<int> RoundResults { get; set; }

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
        public static PlayerType ConvertToCompositeType(Player obj)
        {
            PlayerType playerType = new PlayerType()
            {
                Id = obj.Id,
                Birth = obj.Birth,
                AccountBalance = obj.AccountBalance,
                Country = obj.Country.Id,
                Email = obj.Email,
                Admin = obj.Admin.Id,
                FirstName = obj.FirstName,
                Login = obj.Login,
                Passport = obj.Passport.Id,
                Sex = obj.Sex,
                Password = obj.Password,
                PhoneNumber = obj.PhoneNumber,
                Surname = obj.Surname,
                VerifyFlag = obj.VerifyFlag,
                HaveFriends = new List<int>(),
                IsFriends = new List<int>(),
                Tournaments = new List<int>(),
                RoundResults = new List<int>()
            };
            foreach (var friend in obj.haveFriends)
            {
                playerType.HaveFriends.Add(friend.Id);
            }
            foreach (var friend in obj.isFriends)
            {
                playerType.IsFriends.Add(friend.Id);
            }
            foreach (var tournament in obj.Tournaments)
            {
                playerType.Tournaments.Add(tournament.Id);
            }
            foreach (var roundResult in obj.RoundResults)
            {
                playerType.RoundResults.Add(roundResult.Id);
            }
            return playerType;
        }

        /// <summary>
        /// Converts the type of from composite.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static Player ConvertFromCompositeType(PlayerType obj)
        {
            Player player = new Player()
            {
                Id = obj.Id,
                AccountBalance = obj.AccountBalance,
                Email = obj.Email,
                Birth = obj.Birth,
                Login = obj.Login,
                Surname = obj.Surname,
                Password = obj.Password,
                FirstName = obj.FirstName,
                Sex = obj.Sex,
                VerifyFlag = obj.VerifyFlag,
                PhoneNumber = obj.PhoneNumber
            };
            return player;
        }
    }
}
