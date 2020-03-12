using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MvC5.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MvC5ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}