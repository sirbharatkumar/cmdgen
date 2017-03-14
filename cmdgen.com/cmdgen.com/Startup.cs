using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cmdgen.com.Startup))]
namespace cmdgen.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
