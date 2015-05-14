using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part1
{
    class PassportInformation
    {
        public string PassportNumber { get; set; }

        public string Nationality { get; set; }

        public DateTime ExpirationDate { get; set; }

        public PassportInformation()
        {
            
        }

        public PassportInformation(string passportNumber, string nationality, DateTime expirationDate)
        {
            this.PassportNumber = passportNumber;
            this.Nationality = nationality;
            this.ExpirationDate = expirationDate;
        }
    }
}
