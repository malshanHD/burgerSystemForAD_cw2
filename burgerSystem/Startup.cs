using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(burgerSystem.Startup))]
namespace burgerSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
