namespace FringeNancy
{
    using Microsoft.AspNet.Builder;
    using Nancy.Owin;
 
    public class Startup
    {
        public void Configure(IApplicationBuilder app, Microsoft.Framework.Runtime.IApplicationEnvironment appEnv)
        {
        	app.UseStaticFiles();
            
            var opts = new NancyOptions();
            opts.Bootstrapper = new Bootstrapper(appEnv);
            app.UseOwin(x => x.UseNancy(opts));
        }
    }
}
	