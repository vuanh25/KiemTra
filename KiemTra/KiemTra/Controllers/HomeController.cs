using Microsoft.AspNetCore.Mvc;

namespace KiemTra.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
