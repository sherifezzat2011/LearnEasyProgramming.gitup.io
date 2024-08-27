using Microsoft.AspNetCore.Mvc;

namespace EasyLearn.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Front()
        {
            return View();
        }
        public IActionResult Back()
        {
            return View();
        }
    }
}
