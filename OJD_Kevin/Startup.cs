using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OJD_Kevin.Startup))]
namespace OJD_Kevin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
