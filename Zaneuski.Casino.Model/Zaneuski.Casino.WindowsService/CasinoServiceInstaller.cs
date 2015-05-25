namespace Zaneuski.Casino.WindowsService
{
    using System.ComponentModel;
    using System.ServiceProcess;

    /// <summary>
    /// CasinoServiceInstaller
    /// </summary>
    [RunInstaller(true)]
    public partial class CasinoServiceInstaller : System.Configuration.Install.Installer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CasinoServiceInstaller"/> class.
        /// </summary>
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
