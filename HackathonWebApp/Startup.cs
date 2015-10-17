using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HackathonWebApp.Startup))]
namespace HackathonWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
