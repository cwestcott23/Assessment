using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Timesheets___Assignment.Startup))]
namespace Timesheets___Assignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
