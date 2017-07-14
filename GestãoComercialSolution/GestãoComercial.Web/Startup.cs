using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestãoComercial.Web.Startup))]
namespace GestãoComercial.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
