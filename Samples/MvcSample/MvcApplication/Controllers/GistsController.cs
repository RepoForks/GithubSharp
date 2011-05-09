using GithubSharp.Core.Services;
using System.Web.Mvc;

namespace GithubSharp.MvcSample.MvcApplication.Controllers
{
    public sealed class GistsController : BaseAPIController<Core.API.Gist>
    {
        public GistsController (ICacheProvider Cache, ILogProvider Log)
            : base(Cache, Log)
        {
        	BaseAPI = new Core.API.Gist (Cache, Log);
        }
		
		public ActionResult Index ()
		{
			return View ();
		}
    }
}
