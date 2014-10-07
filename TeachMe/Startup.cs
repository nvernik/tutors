using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tutors.Startup))]
namespace Tutors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
