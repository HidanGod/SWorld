using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(с_мира_по_нитке.Startup))]
namespace с_мира_по_нитке
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
