using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(identity實作.Startup))]
namespace identity實作
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
