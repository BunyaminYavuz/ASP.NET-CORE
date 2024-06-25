using Microsoft.AspNetCore.Mvc;

namespace Fundamentals.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"Ben is coming! {DateTime.Now.ToString()}";
            return View("Index1", message);
        }

        public ViewResult Index2()
        {
            var languages = new String[] {
                "C#",
                "Javascript",
                "Python"
            };
            return View(languages);
        }

        public IActionResult Index3() {
            return Content("Employee");
        }
    }
}