using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmpRegApp.Startup))]
namespace EmpRegApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
