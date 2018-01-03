using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_App_Ratings.Startup))]
namespace Web_App_Ratings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
