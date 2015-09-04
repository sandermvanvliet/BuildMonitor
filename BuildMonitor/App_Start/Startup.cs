using Owin;

namespace BuildMonitor.App_Start
{
    public class Startup
    {
        public void Configure(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}