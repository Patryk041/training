using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrainingTen.Startup))]
namespace TrainingTen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
