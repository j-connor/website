using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mywebsite.Startup))]
namespace mywebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
