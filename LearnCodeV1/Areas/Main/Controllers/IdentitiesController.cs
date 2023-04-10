using Microsoft.AspNetCore.Mvc;

namespace LearnCodeV1.Areas.Main.Controllers
{
    public class IdentitiesController : Controller
    {

        public IActionResult Register() => View();
    }
}
