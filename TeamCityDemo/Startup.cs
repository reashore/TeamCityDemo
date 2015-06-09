
using Microsoft.Owin;
using Owin;
using TeamCityDemo;

[assembly: OwinStartup(typeof(Startup))]

namespace TeamCityDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
