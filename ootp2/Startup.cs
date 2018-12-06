using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ootp2.Startup))]
namespace ootp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
