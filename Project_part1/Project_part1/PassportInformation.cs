namespace Project_part1
{
    using System;

    /// <summary>
    /// Passport information.
    /// </summary>
    class PassportInformation
    {
        /// <summary>
        /// The passport number
        /// </summary>
        private string _passportNumber;

        /// <summary>
        /// The expiration date
        /// </summary>
        private DateTime _expirationDate;

        /// <summary>
        /// The nationality
        /// </summary>
        private string _nationality;

        /// <summary>
        /// Initializes a new instance of the <see cref="PassportInformation"/> class.
        /// </summary>
        public PassportInformation()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PassportInformation"/> class.
        /// </summary>
        /// <param name="passportNumber">The passport number.</param>
        /// <param name="nationality">The nationality.</param>
        /// <param name="expirationDate">The expiration date.</param>
        public PassportInformation(string passportNumber, string nationality, DateTime expirationDate)
        {
            this.Nationality = nationality;
            this.PassportNumber = passportNumber;
            this.ExpirationDate = expirationDate;
        }

        /// <summary>
        /// Gets or sets the passport number.
        /// </summary>
        /// <value>
        /// The passport number.
        /// </value>
        public string PassportNumber
        {
            get { return this._passportNumber; }
            set { this._passportNumber = value; }
        }

        /// <summary>
        /// Gets or sets the expiration date.
        /// </summary>
        /// <value>
        /// The expiration date.
        /// </value>
        public DateTime ExpirationDate
        {
            get { return this._expirationDate; }
            set { this._expirationDate = value; }
        }

        /// <summary>
        /// Gets or sets the nationality.
        /// </summary>
        /// <value>
        /// The nationality.
        /// </value>
        public string Nationality
        {
            get { return this._nationality; }
            set { this._nationality = value; }
        }
    }
}
