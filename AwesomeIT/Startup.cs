using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AwesomeIT.Startup))]
namespace AwesomeIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
