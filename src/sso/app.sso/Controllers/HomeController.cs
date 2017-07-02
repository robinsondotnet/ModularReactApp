using app.utils.Providers;
using Microsoft.AspNetCore.Mvc;

namespace app.sso.Controllers
{
    public class HomeController : Controller
    {
        private readonly IResponseProvider _provider;
        public HomeController(IResponseProvider provider)
        {
           _provider = provider; 
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}