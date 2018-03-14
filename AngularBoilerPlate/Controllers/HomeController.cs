using Microsoft.AspNetCore.Mvc;

namespace AngularBoilerPlate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
