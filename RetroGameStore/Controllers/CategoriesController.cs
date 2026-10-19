using Microsoft.AspNetCore.Mvc;
using RetroGameStore.Models;

namespace RetroGameStore.Controllers
{
    public class CategoriesController : Controller
    {
       
        public IActionResult Index()
        {
            /* a for loop to generate 10 categories*/
            var categories = new List<Category>();
            for (int i = 1; i <= 10; i++)
            {
                categories.Add(new Category { Id = i, Name = "Category " + i });
            }
            return View(categories);
        }

        public IActionResult Browse(string categoryName)
        {
            ViewBag.CategoryName = categoryName;
            return View();
        }   

        public IActionResult Create()
        {
            //display a form to add a new category


            return View();
        }

    }
}
