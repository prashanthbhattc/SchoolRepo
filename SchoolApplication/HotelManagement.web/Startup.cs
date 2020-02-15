using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelManagement.web.Startup))]
namespace HotelManagement.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
