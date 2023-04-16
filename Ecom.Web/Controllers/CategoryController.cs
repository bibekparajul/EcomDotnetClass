using Ecom.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.Web.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        } 
        
        [HttpPost]
        public IActionResult Create(CategoryModel model)
        {
            Console.WriteLine(model.Name);
            return View();
        }
    }
}
