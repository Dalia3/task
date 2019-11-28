using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FekretyFinal.Startup))]
namespace FekretyFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
