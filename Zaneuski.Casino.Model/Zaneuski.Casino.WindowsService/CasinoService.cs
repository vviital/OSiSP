namespace Zaneuski.Casino.WindowsService
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using System.ServiceProcess;

    /// <summary>
    /// CasinoService
    /// </summary>
    public partial class CasinoService : ServiceBase
    {
        /// <summary>
        /// The hosts
        /// </summary>
        private ServiceHost[] _hosts;

        /// <summary>
        /// Initializes a new instance of the <see cref="CasinoService"/> class.
        /// </summary>
        public CasinoService()
        {
            Assembly assembly = Assembly.Load("Zaneuski.Casino.WcfServiceLibrary");

            Type[] types = assembly.GetTypes().Where(o => o.IsClass && o.GetInterfaces().Count() == 1).ToArray();

            _hosts = new ServiceHost[types.Count()];

            for (int i = 0; i < this._hosts.Count(); ++i)
            {
                this._hosts[i] = null;
            }
            InitializeComponent();
        }

        /// <summary>
        /// When implemented in a derived class, executes when a Start command is sent to the service by the Service Control Manager (SCM) or when the operating system starts (for a service that starts automatically). Specifies actions to take when the service starts.
        /// </summary>
        /// <param name="args">Data passed by the start command.</param>
        protected override void OnStart(string[] args)
        {
            //http://localhost:9001/CalcService
            string adrHttpBase = "http://localhost:8943/";

            Assembly assembly = Assembly.Load("Zaneuski.Casino.WcfServiceLibrary");

            Type[] types = assembly.GetTypes().Where(o => o.IsClass && o.GetInterfaces().Count() == 1).ToArray();

            for (int i = 0; i < this._hosts.Count(); ++i)
            {
                if (this._hosts[i] != null) this._hosts[i].Close();

                string serviceName = types[i].ToString().Split('.').Last();
                string strAdrHTTP = adrHttpBase + serviceName;

                Uri adrbase = new Uri(strAdrHTTP);

                this._hosts[i] = new ServiceHost(types[i], adrbase);

                ServiceMetadataBehavior mBehave = new ServiceMetadataBehavior();
                this._hosts[i].Description.Behaviors.Add(mBehave);

                Type interfaceType = types[i].GetInterfaces().Last();

                BasicHttpBinding httpb = new BasicHttpBinding();
                this._hosts[i].AddServiceEndpoint(interfaceType, httpb, strAdrHTTP);
                this._hosts[i].AddServiceEndpoint(typeof(IMetadataExchange),
                MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

                this._hosts[i].Open();
            }
        }

        /// <summary>
        /// When implemented in a derived class, executes when a Stop command is sent to the service by the Service Control Manager (SCM). Specifies actions to take when a service stops running.
        /// </summary>
        protected override void OnStop()
        {
            for (int i = 0; i < this._hosts.Count(); ++i)
            {
                if (this._hosts[i] != null)
                {
                    this._hosts[i].Close();
                    this._hosts[i] = null;
                }
            }
        }
    }
}
