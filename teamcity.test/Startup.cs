using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(teamcity.test.Startup))]
namespace teamcity.test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
