using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Toci.Front.Samples.Startup))]
namespace Toci.Front.Samples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
