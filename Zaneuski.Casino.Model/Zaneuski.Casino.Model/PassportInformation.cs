using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    public class PassportInformation : BaseUnit
    {
        public string PassportNumber { get; set; }

        public string Nationality { get; set; }

        public DateTime ExpirationDate { get; set; }

        public virtual Player Player { get; set; }

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
