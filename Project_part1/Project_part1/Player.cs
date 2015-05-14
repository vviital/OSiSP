using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part1
{
    class Player : Person
    {
        public string PhoneNumber { get; set; }

        public double AccountBalance { get; set; }

        public bool VerifyFlag { get; set; }

        public List<Player> Friends { get; set; }
 
        public Player()
        {
            
        }

        public Player(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth, Country country, string phoneNumber)
            : base(login, password, surname, firstname, sex, email, birth, country)
        {
            this.PhoneNumber = phoneNumber;
            this.AccountBalance = 0;
            this.VerifyFlag = false;
        }

        public Player(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth, Country country, string phoneNumber, double accountBalance, bool verifyFlag)
            : base(login, password, surname, firstname, sex, email, birth, country)
        {
            this.PhoneNumber = phoneNumber;
            this.AccountBalance = accountBalance;
            this.VerifyFlag = verifyFlag;
        }
    }
}
