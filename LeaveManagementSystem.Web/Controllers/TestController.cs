using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new Models.TestViewModel
            {
                Name = "Student of MVC Mastery",
                DateOfBirth = new DateTime(1964, 12, 01)
            };
            return View(data);
        }
    }
}
