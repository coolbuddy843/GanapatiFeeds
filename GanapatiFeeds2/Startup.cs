using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(GanapatiFeeds2.StartupOwin))]

namespace GanapatiFeeds2
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
