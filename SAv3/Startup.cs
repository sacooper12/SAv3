using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAv3.Startup))]
namespace SAv3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
