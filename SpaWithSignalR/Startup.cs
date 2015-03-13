using Owin;

namespace CodePound.Demos.SpaWithSignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}