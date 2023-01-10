using Microsoft.AspNetCore.Mvc;

namespace MyGraphTestClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
