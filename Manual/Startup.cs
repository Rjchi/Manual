using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Manual.Startup))]
namespace Manual
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
