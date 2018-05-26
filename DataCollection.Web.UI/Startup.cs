using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataCollection.Web.UI.Startup))]
namespace DataCollection.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
