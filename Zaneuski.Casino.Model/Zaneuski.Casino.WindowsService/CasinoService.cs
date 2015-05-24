using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
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
            _hosts = new ServiceHost[1];
            this._hosts[0] = null;
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (this._hosts[0] != null) _hosts[0].Close();

            foreach (var serviceHost in this._hosts)
            {
                serviceHost.Open();
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
