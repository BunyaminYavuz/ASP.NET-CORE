using Microsoft.AspNetCore.Mvc;

namespace Fundamentals.Controllers
{
    public class EmployeeController : Controller
    {
        public String Index() {
            return "Ben is coming!";
        }
    }
}