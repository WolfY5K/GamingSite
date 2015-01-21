using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GamingSite.Startup))]
namespace GamingSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
