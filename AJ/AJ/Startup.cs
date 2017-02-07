using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AJ.Startup))]
namespace AJ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
