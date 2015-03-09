using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2015MVC.Startup))]
namespace _2015MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
