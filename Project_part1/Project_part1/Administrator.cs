namespace Project_part1
{
    using System.Collections.Generic;

    /// <summary>
    /// Class which represent administrator.
    /// </summary>
    class Administrator : Person
    {
        /// <summary>
        /// The verified players
        /// </summary>
        private List<Player> _verifiedPlayers;

        /// <summary>
        /// The unverified players
        /// </summary>
        private List<Player> _unverifiedPlayers;

        /// <summary>
        /// Initializes a new instance of the <see cref="Administrator"/> class.
        /// </summary>
        public Administrator()
        {
            this.VerifiedPlayers = new List<Player>();
            this.UnverifiedPlayers = new List<Player>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Administrator"/> class.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <param name="password">The password.</param>
        /// <param name="surname">The surname.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="email">The email.</param>
        public Administrator(string login, string password, string surname, string firstName, string phoneNumber,
            string email)
            : base(login, password, surname, firstName, phoneNumber, email)
        {
            this.VerifiedPlayers = new List<Player>();
            this.UnverifiedPlayers = new List<Player>();
        }

        /// <summary>
        /// Gets or sets the verified players.
        /// </summary>
        /// <value>
        /// The verified players.
        /// </value>
        public List<Player> VerifiedPlayers
        {
            get { return this._verifiedPlayers; }
            set { this._verifiedPlayers = value; }
        }

        /// <summary>
        /// Gets or sets the unverified players.
        /// </summary>
        /// <value>
        /// The unverified players.
        /// </value>
        public List<Player> UnverifiedPlayers
        {
            get { return this._unverifiedPlayers; }
            set { this._unverifiedPlayers = value; }
        }
    }
}
