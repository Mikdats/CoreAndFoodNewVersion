using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
