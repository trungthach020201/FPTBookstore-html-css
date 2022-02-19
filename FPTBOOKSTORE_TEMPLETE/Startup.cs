using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FPTBOOKSTORE_TEMPLETE.Startup))]
namespace FPTBOOKSTORE_TEMPLETE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
