using CourseRegistrationApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegistrationApp.Controllers
{
    public class CourseController: Controller
    {
        public IActionResult Index() {
            return View();
        }
        public IActionResult Register() {
            return View("Register");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply(Candidate model) {
            return View("Index");
        }
    }
}