using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MBF_MVC.Startup))]
namespace MBF_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
