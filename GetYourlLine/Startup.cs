using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetYourlLine.Startup))]
namespace GetYourlLine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
