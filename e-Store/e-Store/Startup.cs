using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(e_Store.Startup))]
namespace e_Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
