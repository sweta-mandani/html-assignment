using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Signup.Startup))]
namespace Signup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
