using DBfirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace DBfirstApproach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductsContext db;


        public HomeController(ProductsContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult EditProduct(int id)
        {
            var product = db.Products.FirstOrDefault(x => x.Id == id);
            return View();
        }
        [HttpPost]
         public IActionResult EditProduct(Product product)
        {
            db.Products.Update(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteProduct(Product product)
        {
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ReadProduct(int id)
        {
            var product = db.Products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();  
            }

            return View(product);  
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    
}