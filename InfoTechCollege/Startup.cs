using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InfoTechCollege.Startup))]
namespace InfoTechCollege
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
