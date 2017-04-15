using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CatShelterMVC.Startup))]
namespace CatShelterMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
