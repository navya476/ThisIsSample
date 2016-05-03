using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThisSample.Startup))]
namespace ThisSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
