using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocietyAnalysisWeb.Startup))]
namespace SocietyAnalysisWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
