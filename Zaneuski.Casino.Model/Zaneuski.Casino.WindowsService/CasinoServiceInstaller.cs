using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace Zaneuski.Casino.WindowsService
{
    [RunInstaller(true)]
    public partial class CasinoServiceInstaller : System.Configuration.Install.Installer
    {
        public CasinoServiceInstaller()
        {
            // InitializeComponent();
            serviceProcessInstaller1 = new ServiceProcessInstaller();
            serviceProcessInstaller1.Account = ServiceAccount.LocalSystem;
            serviceInstaller1 = new ServiceInstaller();
            serviceInstaller1.ServiceName = "CasinoService";
            serviceInstaller1.DisplayName = "CasinoService";
            serviceInstaller1.Description = "Casino Data exchange service";
            serviceInstaller1.StartType = ServiceStartMode.Automatic;
            Installers.Add(serviceProcessInstaller1);
            Installers.Add(serviceInstaller1);
        }
    }
}
