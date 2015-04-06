namespace FringeNancy
{
    using Nancy;
    using Nancy.TinyIoc;
    using Microsoft.Framework.Runtime;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        private IApplicationEnvironment appEnv;
        
        protected override IRootPathProvider RootPathProvider { get { return new RootPathProvider(appEnv); }}
        
        public Bootstrapper(IApplicationEnvironment appEnv)
        {
            this.appEnv = appEnv;
        }
        
        protected override void ApplicationStartup(TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            this.Conventions.ViewLocationConventions.Add((viewName, model, context) =>
            {
                return string.Concat("wwwroot/", viewName);
            });
        }
    }
    
    public class RootPathProvider : IRootPathProvider
    {
        
        public IApplicationEnvironment appEnv;
        
        public RootPathProvider(IApplicationEnvironment appEnv)
        {
            this.appEnv = appEnv;
        }
        
        public string GetRootPath() 
        {
            return appEnv.ApplicationBasePath;
        }
    }
}
