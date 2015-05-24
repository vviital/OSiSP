using System;

namespace Zaneuski.Casino.Model
{
    public class Person : BaseUnit
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string Surname { get; set; }

        public string FirstName { get; set; }

        public bool Sex { get; set; }

        public string Email { get; set; }

        public DateTime Birth { get; set; }

        public Person()
        {

        }

        public Person(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth)
        {
            this.Login = login;
            this.Password = password;
            this.Surname = surname;
            this.FirstName = firstname;
            this.Sex = sex;
            this.Email = email;
            this.Birth = birth;
        }
    }
}
