using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebStoreNew.Startup))]
namespace WebStoreNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
