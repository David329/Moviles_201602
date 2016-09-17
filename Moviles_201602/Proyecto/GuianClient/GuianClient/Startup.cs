using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GuianClient.Startup))]
namespace GuianClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
