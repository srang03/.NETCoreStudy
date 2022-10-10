using Microsoft.AspNetCore.Mvc;

namespace MVCBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
