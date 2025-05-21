using Microsoft.AspNetCore.Mvc;

namespace Task1_mvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Create()
        {
            return View();
        }
        public ViewResult Edit()
        {
            return View();
        }
    }
}
