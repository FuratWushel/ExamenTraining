using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamenTraining.Startup))]
namespace ExamenTraining
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
