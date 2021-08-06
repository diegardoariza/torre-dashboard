using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTorreDashboard.Startup))]
namespace MyTorreDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
