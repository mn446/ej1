using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ej1.Startup))]
namespace ej1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
