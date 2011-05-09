using System.Web.Mvc;
using System.Web.Routing;
using System.Web;

namespace GithubSharp.MvcSample.MvcApplication
{
    public class ServerApp : HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("favicon.ico");
            routes.IgnoreRoute("robots.txt");

            // Route name
            // URL with parameters
            // Parameter defaults
            routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = "" });
        }

        protected void Application_Start()
        {

            AreaRegistration.RegisterAllAreas();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            DependencyResolver.SetResolver(new Munq.MVC3.MunqDependencyResolver());

            Munq.MVC3.MunqDependencyResolver.Container.RegisterInstance<Core.Services.ICacheProvider>(new GithubSharp.Plugins.CacheProviders.WebCache.WebCacher());
            Munq.MVC3.MunqDependencyResolver.Container.RegisterInstance<Core.Services.ILogProvider>(new GithubSharp.Plugins.LogProviders.NullOrCustomLogProvider.NullOrCustomLogProvider());
        }

    }
}
