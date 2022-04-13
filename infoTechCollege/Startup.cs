using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(infoTechCollege.Startup))]
namespace infoTechCollege
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
