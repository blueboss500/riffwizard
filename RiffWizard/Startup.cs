using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RiffWizard.Startup))]
namespace RiffWizard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
