using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200407812A1.Startup))]
namespace _200407812A1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
