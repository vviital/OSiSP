using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    class Player : Person
    {
        public string PhoneNumber { get; set; }

        public Money AccountBalance { get; set; }

        public bool VerifyFlag { get; set; }

        public virtual List<Player> Friends { get; set; }

        public virtual Administrator Admin { get; set; }

        public virtual List<Tournament> Tournaments { get; set; }

        public virtual PassportInformation Passport { get; set; }

        public virtual List<PlayerResult> PlayerResults { get; set; }

        public Player()
        {

        }

        public Player(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth, Country country, string phoneNumber, PassportInformation passport)
            : base(login, password, surname, firstname, sex, email, birth, country)
        {
            this.PhoneNumber = phoneNumber;
            this.AccountBalance = new Money(0);
            this.VerifyFlag = false;
            this.Passport = passport;
        }

        public Player(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth, Country country, string phoneNumber, PassportInformation passport, Money accountBalance, bool verifyFlag)
            : base(login, password, surname, firstname, sex, email, birth, country)
        {
            this.PhoneNumber = phoneNumber;
            this.AccountBalance = accountBalance;
            this.VerifyFlag = verifyFlag;
            this.Passport = passport;
        }
    }
}
