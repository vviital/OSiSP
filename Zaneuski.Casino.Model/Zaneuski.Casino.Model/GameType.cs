using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    public class GameType : BaseUnit, IInitializer
    {
        public string Type { get; set; }

        public virtual List<Tournament> Tournaments { get; set; } 

        public GameType()
        {
            Initialize();
        }

        public GameType(string type)
        {
            Initialize();
            this.Type = type;
        }

        public void Initialize()
        {
            this.Tournaments = new List<Tournament>();
        }
    }
}
