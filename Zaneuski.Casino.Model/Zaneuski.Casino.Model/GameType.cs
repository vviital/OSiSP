using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    public class GameType : BaseUnit
    {
        public string Type { get; set; }

        public virtual List<Tournament> Tournaments { get; set; } 

        public GameType()
        {

        }

        public GameType(string type)
        {
            this.Type = type;
        }
    }
}
