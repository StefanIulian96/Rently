using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rently.Startup))]
namespace Rently
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
