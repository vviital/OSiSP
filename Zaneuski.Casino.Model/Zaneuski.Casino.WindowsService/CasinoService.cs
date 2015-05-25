using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Security;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.WindowsService
{
    public partial class CasinoService : ServiceBase
    {
        private ServiceHost[] _hosts;

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
