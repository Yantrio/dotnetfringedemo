namespace FringeNancy
{
    using Microsoft.AspNet.Builder;
    using Nancy.Owin;
    using System;
 
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
        	app.UseStaticFiles();
        	Console.WriteLine("test");
            app.UseOwin(x => x.UseNancy());
        }
    }
}
	