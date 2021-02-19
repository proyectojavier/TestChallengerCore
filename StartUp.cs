using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChallengerCore.App_Start.StartUpFB))]
namespace ChallengerCore.App_Start
{
    public partial class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}