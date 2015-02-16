using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectApps.Startup))]
namespace ProjectApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
