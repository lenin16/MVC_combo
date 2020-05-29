using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Selecionar_web.Startup))]
namespace Selecionar_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
