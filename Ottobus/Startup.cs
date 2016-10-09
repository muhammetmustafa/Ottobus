using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ottobus.Startup))]
namespace Ottobus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
