using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2014139610_MVC.Startup))]
namespace _2014139610_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
