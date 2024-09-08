using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JustASampleAuthorization.Startup))]
namespace JustASampleAuthorization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
