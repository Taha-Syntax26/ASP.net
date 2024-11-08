using Microsoft.AspNetCore.Mvc;

namespace WebApplication08.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            TempData["designation"] = "Softeware developer";
                TempData.Keep();

            ViewBag.name = "Muhammad Taha";
            ViewData["Salary"] = "Your Salary Is 8$ Billion ";
            ViewData["Designation"] = "CEO of the Company";

            return View();
        }


        public IActionResult Airbuds()
        {
            TempData["Brand"] = "Apple";

            TempData.Keep();

            return View();

        }

        public IActionResult Laptop() 
        {
            TempData.Keep();
            return View();
        }

        public IActionResult Mobiles()
        {
            TempData.Keep();
            return View();
        }
    }
}
