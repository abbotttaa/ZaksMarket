using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZaksMarketplace.Startup))]
namespace ZaksMarketplace
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
