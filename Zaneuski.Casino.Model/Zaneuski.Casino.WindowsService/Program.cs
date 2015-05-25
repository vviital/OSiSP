namespace Zaneuski.Casino.WindowsService
{
    using System.ServiceProcess;

    /// <summary>
    /// Program
    /// </summary>
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
