namespace Project_part1
{
    using System.Collections.Generic;

    /// <summary>
    /// Class Player.
    /// </summary>
    class Player : Person
    {
        /// <summary>
        /// The verify flag
        /// </summary>
        protected bool _verifyFlag;

        /// <summary>
        /// The passport information
        /// </summary>
        protected PassportInformation _passportInformation;

        /// <summary>
        /// The account balance
        /// </summary>
        protected double _accountBalance;

        /// <summary>
        /// The friends
        /// </summary>
        protected List<Friend> _friends;
 
        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        public Player()
            : base()
        {
            this.Friends = new List<Friend>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <param name="password">The password.</param>
        /// <param name="surname">The surname.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="email">The email.</param>
        /// <param name="verifyFlag">if set to <c>true</c> [verify flag].</param>
        /// <param name="passport">The passport.</param>
        /// <param name="accountBalance">The account balance.</param>
        public Player(string login, string password, string surname, string firstName, string phoneNumber, string email,
            bool verifyFlag, PassportInformation passport, double accountBalance)
            : base(login, password, surname, firstName, phoneNumber, email)
        {
            this.VerifyFlag = verifyFlag;
            this.Passport = passport;
            this.AccountBalance = accountBalance;
            this.Friends = new List<Friend>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <param name="password">The password.</param>
        /// <param name="surname">The surname.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="email">The email.</param>
        /// <param name="verifyFlag">if set to <c>true</c> [verify flag].</param>
        /// <param name="passport">The passport.</param>
        /// <param name="accountBalance">The account balance.</param>
        /// <param name="friends">The friends.</param>
        public Player(string login, string password, string surname, string firstName, string phoneNumber, string email,
           bool verifyFlag, PassportInformation passport, double accountBalance, List<Friend> friends)
            : base(login, password, surname, firstName, phoneNumber, email)
        {
            this.VerifyFlag = verifyFlag;
            this.Passport = passport;
            this.AccountBalance = accountBalance;
            this.Friends = friends;
        }

        /// <summary>
        /// Gets or sets a value indicating whether [verify flag].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [verify flag]; otherwise, <c>false</c>.
        /// </value>
        public bool VerifyFlag
        {
            get { return this._verifyFlag; }
            set { this._verifyFlag = value; }
        }

        /// <summary>
        /// Gets or sets the passport information.
        /// </summary>
        /// <value>
        /// The passport information.
        /// </value>
        public PassportInformation Passport
        {
            get { return this._passportInformation; }
            set { this._passportInformation = value; }
        }

        /// <summary>
        /// Gets or sets the account balance.
        /// </summary>
        /// <value>
        /// The account balance.
        /// </value>
        public double AccountBalance
        {
            get { return this._accountBalance; }
            set { this._accountBalance = value; }
        }

        /// <summary>
        /// Gets or sets the friends.
        /// </summary>
        /// <value>
        /// The friends.
        /// </value>
        public List<Friend> Friends
        {
            get { return this._friends; }
            set { this._friends = value; }
        } 
    }
}
