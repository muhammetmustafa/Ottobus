using Microsoft.Owin;
using Ottobus.Web;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace Ottobus.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }       
    }
}
