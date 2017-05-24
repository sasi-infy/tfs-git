using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoOnline.Startup))]
namespace GoOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //Hello
        }
    }
}
