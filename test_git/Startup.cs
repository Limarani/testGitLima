using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_git.Startup))]
namespace test_git
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
