namespace Project_part1
{
    /// <summary>
    /// Class which represent a person.
    /// </summary>
    class Person
    {
        /// <summary>
        /// The login
        /// </summary>
        protected string _login;

        /// <summary>
        /// The password
        /// </summary>
        protected string _password;

        /// <summary>
        /// The surname
        /// </summary>
        protected string _surname;

        /// <summary>
        /// The first name
        /// </summary>
        protected string _firstName;

        /// <summary>
        /// The phone number
        /// </summary>
        protected string _phoneNumber;

        /// <summary>
        /// The email
        /// </summary>
        protected string _email;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <param name="password">The password.</param>
        /// <param name="surname">The surname.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="email">The email.</param>
        public Person(string login, string password, string surname, string firstName, string phoneNumber, string email)
        {
            this.Login = login;
            this.Password = password;
            this.Surname = surname;
            this.FirstName = firstName;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        /// <summary>
        /// Gets or sets the login.
        /// </summary>
        /// <value>
        /// The login.
        /// </value>
        public string Login
        {
            get { return this._login; }
            set { this._login = value; }
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        public string Surname
        {
            get { return this._surname; }
            set { this._surname = value; }
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
    }
}
