using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaneuski.Casino.Model;
using Zaneuski.Casino.WcfServiceLibrary;

namespace Zaneuski.Casino.WpfApplication.Model
{
    public class RegistrationModel
    {
        public PlayerType Player { get; set; }

        public PassportInformationType Passport { get; set; }

        public RegistrationModel()
        {
            Player = new PlayerType();
            Passport = new PassportInformationType();
        }
    }
}
