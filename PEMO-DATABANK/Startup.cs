using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PEMO_DATABANK.Startup))]
namespace PEMO_DATABANK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
