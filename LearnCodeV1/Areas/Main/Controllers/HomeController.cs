using Microsoft.AspNetCore.Mvc;

namespace LearnCodeV1.Areas.Main.Controllers
{
    [Area("Main")]
    public class HomeController : Controller
    {
        public IActionResult Home() => View();
    }
}
