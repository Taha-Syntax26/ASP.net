using DBfirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
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