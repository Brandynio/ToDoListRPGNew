using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoListRPG.Startup))]
namespace ToDoListRPG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
