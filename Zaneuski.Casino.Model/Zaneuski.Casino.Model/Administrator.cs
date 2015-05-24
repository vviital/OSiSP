using System;
using System.Collections.Generic;

namespace Zaneuski.Casino.Model
{
    public class Administrator : Person, IInitializer
    {
        public virtual List<Player> ObservedPlayers { get; set; }

        public virtual List<Tournament> SupervisedTournaments { get; set; }
        
        public virtual Country Country { get; set; }

        public Administrator()
            : base()
        {
            Initialize();
        }

        public Administrator(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth, Country homeCountry)
            : base(login, password, surname, firstname, sex, email, birth)
        {
            Initialize();
        }

        public Administrator(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth, Country homeCountry, List<Player> observedPlayers, List<Tournament> supervisedTournaments)
            : base(login, password, surname, firstname, sex, email, birth)
        {
            this.ObservedPlayers = observedPlayers;
            this.SupervisedTournaments = supervisedTournaments;
            this.Country = homeCountry;
        }

        public void Initialize()
        {
            this.ObservedPlayers = new List<Player>();
            this.SupervisedTournaments = new List<Tournament>();
        }
    }
}
