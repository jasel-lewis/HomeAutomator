using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeAutomator.Startup))]
namespace HomeAutomator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
