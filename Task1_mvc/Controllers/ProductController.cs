using Microsoft.AspNetCore.Mvc;
using Task1_mvc.DataBase;
using Task1_mvc.Models;

namespace Task1_mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext context;

        public ProductController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var prodacts = context.Products.ToList();
            return View(prodacts);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product prodact)
        {
            context.Products.Add(prodact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ViewResult Details(int id)
        {
            var prodact = context.Products.FirstOrDefault(e => e.Id == id);
            if (prodact == null)
            {
                return View("Index");
            }
            return View(prodact);
        }
        public ViewResult Edit()
        {
            return View();
        }
        [HttpGet]
        public RedirectToActionResult Delete(int id)
        {
            var prodact = context.Products.FirstOrDefault(e => e.Id == id);
            if (prodact == null)
            { return RedirectToAction("Index"); }
            context.Products.Remove(prodact);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
