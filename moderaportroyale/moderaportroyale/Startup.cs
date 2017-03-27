using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(moderaportroyale.Startup))]
namespace moderaportroyale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
