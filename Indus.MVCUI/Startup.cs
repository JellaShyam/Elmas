using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Elmas.MVCUI.Startup))]
namespace Elmas.MVCUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
