using Microsoft.Owin;
using Owin;
using sample;

[assembly: OwinStartup(typeof(Startup))]

namespace sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
