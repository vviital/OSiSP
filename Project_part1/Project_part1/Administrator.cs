using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part1
{
    class Administrator : Person
    {
        public Administrator()
            : base()
        {
            
        }

        public Administrator(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth, Country homeCountry)
            : base(login, password, surname, firstname, sex, email, birth, homeCountry)
        {
            
        }
    }
}
