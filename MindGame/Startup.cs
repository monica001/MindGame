using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MindGame.Startup))]
namespace MindGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
