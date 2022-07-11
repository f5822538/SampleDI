using Microsoft.AspNetCore.Mvc;

namespace WebApiEx1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
