using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductsCSV.Startup))]
namespace ProductsCSV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
