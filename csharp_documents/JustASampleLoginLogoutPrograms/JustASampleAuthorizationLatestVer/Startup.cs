using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JustASampleAuthorizationLatestVer.Startup))]
namespace JustASampleAuthorizationLatestVer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
