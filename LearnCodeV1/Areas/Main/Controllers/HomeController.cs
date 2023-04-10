using Microsoft.AspNetCore.Mvc;

namespace LearnCodeV1.Areas.Main.Controllers
{
    [Area("Main")]
    public class HomeController : Controller
    {
        public IActionResult Home() => View();

        [HttpGet]
        [Route("Register")]
        public IActionResult RegisterByPhone() => View();

        [HttpPost]
        [Route("Register")]
        public IActionResult RegisterByPhone(int b)
        {
            return View();
        }

    }
}
