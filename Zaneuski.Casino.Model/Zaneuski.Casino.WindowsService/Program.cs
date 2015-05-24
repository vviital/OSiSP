using System.ServiceProcess;

namespace Zaneuski.Casino.WindowsService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new CasinoService() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
