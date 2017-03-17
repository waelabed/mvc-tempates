using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_app5.Startup))]
namespace mvc_app5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
