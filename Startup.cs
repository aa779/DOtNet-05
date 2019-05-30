using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DOtNet_05.Startup))]
namespace DOtNet_05
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
