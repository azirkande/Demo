using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThirdDemo.Startup))]
namespace ThirdDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
