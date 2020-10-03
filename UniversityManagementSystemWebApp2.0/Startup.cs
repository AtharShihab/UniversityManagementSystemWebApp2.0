using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversityManagementSystemWebApp2._0.Startup))]
namespace UniversityManagementSystemWebApp2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
