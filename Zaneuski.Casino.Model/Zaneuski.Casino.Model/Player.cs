using System;
using System.Collections.Generic;

namespace Zaneuski.Casino.Model
{
    public class Player : Person, IInitializer
    {
        public string PhoneNumber { get; set; }

        public double AccountBalance { get; set; }

        public bool VerifyFlag { get; set; }

        public virtual List<Player> isFriends { get; set; }

        public virtual List<Player> haveFriends { get; set; } 

        public virtual Administrator Admin { get; set; }

        public virtual List<Tournament> Tournaments { get; set; }

        public virtual PassportInformation Passport { get; set; }

        public virtual List<RoundResult> RoundResults { get; set; }

        public virtual Country Country { get; set; }

        public Player()
        {
            Initialize();
        }

        public Player(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth, Country country, string phoneNumber, PassportInformation passport)
            : base(login, password, surname, firstname, sex, email, birth)
        {
            Initialize();
            this.PhoneNumber = phoneNumber;
            this.AccountBalance = 0;
            this.VerifyFlag = false;
            this.Passport = passport;
            this.Country = country;
        }

        public Player(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth, Country country, string phoneNumber, PassportInformation passport, double accountBalance, bool verifyFlag)
            : base(login, password, surname, firstname, sex, email, birth)
        {
            Initialize();
            this.PhoneNumber = phoneNumber;
            this.AccountBalance = accountBalance;
            this.VerifyFlag = verifyFlag;
            this.Passport = passport;
            this.Country = country;
        }

        public void Initialize()
        {
            this.isFriends = new List<Player>();
            this.haveFriends = new List<Player>();
            //isFriends.Add(this);
            //haveFriends.Add(this);
            this.Tournaments = new List<Tournament>();
            this.RoundResults = new List<RoundResult>();
        }
    }
}
