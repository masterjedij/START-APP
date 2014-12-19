using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(START.Startup))]
namespace START
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
