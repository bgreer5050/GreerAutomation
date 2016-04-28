using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreerAutomation.Startup))]
namespace GreerAutomation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
