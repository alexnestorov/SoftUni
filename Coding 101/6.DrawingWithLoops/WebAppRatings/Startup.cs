using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppRatings.Startup))]
namespace WebAppRatings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
