using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    public class Administrator : Person, IInitializer
    {
        public virtual List<Player> ObservedPlayers { get; set; }

        public virtual List<Tournament> SupervisedTournaments { get; set; }

        public Administrator()
            : base()
        {
            Initialize();
        }

        public Administrator(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth, Country homeCountry)
            : base(login, password, surname, firstname, sex, email, birth, homeCountry)
        {
            Initialize();
        }

        public Administrator(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth, Country homeCountry, List<Player> observedPlayers, List<Tournament> supervisedTournaments)
            : base(login, password, surname, firstname, sex, email, birth, homeCountry)
        {
            this.ObservedPlayers = observedPlayers;
            this.SupervisedTournaments = supervisedTournaments;
        }

        public void Initialize()
        {
            this.ObservedPlayers = new List<Player>();
            this.SupervisedTournaments = new List<Tournament>();
        }
    }
}
