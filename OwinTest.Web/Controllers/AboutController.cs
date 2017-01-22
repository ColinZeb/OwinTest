using System.Web.Mvc;

namespace OwinTest.Web.Controllers
{
    public class AboutController : OwinTestControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}