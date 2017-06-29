using Microsoft.AspNetCore.Mvc;

namespace app.sso.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}