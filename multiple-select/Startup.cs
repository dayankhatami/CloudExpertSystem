using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(multiple_select.Startup))]
namespace multiple_select
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
