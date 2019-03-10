using Microsoft.AspNetCore.Mvc;

namespace TesteProgrammers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
