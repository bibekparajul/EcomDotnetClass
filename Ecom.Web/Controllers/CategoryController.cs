using Microsoft.AspNetCore.Mvc;

namespace Ecom.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
