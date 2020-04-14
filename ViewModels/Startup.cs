using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViewModels.Startup))]
namespace ViewModels
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
