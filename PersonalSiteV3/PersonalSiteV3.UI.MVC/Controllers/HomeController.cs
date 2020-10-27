using System.Web.Mvc;

namespace PersonalSiteV3.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Links()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
