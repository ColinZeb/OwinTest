using System.Web.Mvc;

namespace OwinTest.Web.Controllers
{
    public class HomeController : OwinTestControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}