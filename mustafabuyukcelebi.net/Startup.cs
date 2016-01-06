using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mustafabuyukcelebi.net.Startup))]
namespace mustafabuyukcelebi.net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
