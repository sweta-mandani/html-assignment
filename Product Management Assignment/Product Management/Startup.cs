using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Product_Management.Startup))]
namespace Product_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
