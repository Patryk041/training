using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleShowdown.Startup))]
namespace SampleShowdown
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
