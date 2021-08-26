using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyDuka.WebUI.Startup))]
namespace MyDuka.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
