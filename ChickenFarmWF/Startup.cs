using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChickenFarmWF.Startup))]
namespace ChickenFarmWF
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
