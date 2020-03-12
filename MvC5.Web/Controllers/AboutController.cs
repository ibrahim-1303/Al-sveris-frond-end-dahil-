using System.Web.Mvc;

namespace MvC5.Web.Controllers
{
    public class AboutController : MvC5ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}