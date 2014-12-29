using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Typeahead.Startup))]
namespace Typeahead
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
