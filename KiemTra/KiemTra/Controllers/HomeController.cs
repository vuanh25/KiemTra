using Microsoft.AspNetCore.Mvc;

namespace KiemTra.Controllers
{
    public class HomeController : Controller
    {
        // Kiem tra 
        public IActionResult Index()
        {
            return View();
        }
    }
}
