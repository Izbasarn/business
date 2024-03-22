using Microsoft.AspNetCore.Mvc;

namespace business.Controllers
{
    public class izbaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
