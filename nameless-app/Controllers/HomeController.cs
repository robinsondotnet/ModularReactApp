using Microsoft.AspNetCore.Mvc;

namespace nameless_app.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return
            View();
        }
    }
}