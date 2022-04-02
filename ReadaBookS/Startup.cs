using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReadaBookS.Startup))]
namespace ReadaBookS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
