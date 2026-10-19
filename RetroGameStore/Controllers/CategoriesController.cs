using Microsoft.AspNetCore.Mvc;

namespace RetroGameStore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
