using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ness.HrTracker.Web.Startup))]
namespace Ness.HrTracker.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
