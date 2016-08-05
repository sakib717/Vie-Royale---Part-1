using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vie_Royale.Startup))]
namespace Vie_Royale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
