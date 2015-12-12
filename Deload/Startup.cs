using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Deload.Startup))]
namespace Deload
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
