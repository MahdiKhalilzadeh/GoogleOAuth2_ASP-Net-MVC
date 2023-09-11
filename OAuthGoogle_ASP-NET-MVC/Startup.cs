using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OAuthGoogle.Startup))]
namespace OAuthGoogle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
