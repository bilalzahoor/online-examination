using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(online_examination.Startup))]
namespace online_examination
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
