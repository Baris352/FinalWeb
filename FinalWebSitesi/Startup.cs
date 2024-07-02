using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalWebSitesi.Startup))]
namespace FinalWebSitesi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
