using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(devops.Startup))]
namespace devops
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
