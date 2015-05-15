using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    class GameType : BaseUnit
    {
        public string GameTypeCode { get; set; }

        public string Type { get; set; }

        public GameType()
        {

        }

        public GameType(string gameTypeCode, string type)
        {
            this.GameTypeCode = gameTypeCode;
            this.Type = type;
        }
    }
}
