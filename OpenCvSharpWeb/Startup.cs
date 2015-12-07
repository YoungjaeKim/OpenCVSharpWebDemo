using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenCvSharpWeb.Startup))]
namespace OpenCvSharpWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
