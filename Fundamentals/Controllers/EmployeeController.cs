using Microsoft.AspNetCore.Mvc;

namespace Fundamentals.Controllers
{
    public class EmployeeController : Controller
    {
        public String Index()
        {
            return "Ben is coming!";
        }

        public ViewResult Index2()
        {
            return View("Index");
        }

        public IActionResult Index3() {
            return Content("Employee");
        }
    }
}