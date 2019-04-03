using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BanXeDap2.Startup))]
namespace BanXeDap2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
