using LearnCodeV1.Core.Services;
using LearnCodeV1.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LearnCodeV1.Areas.Main.Controllers
{
    [Area("Main")]
    public class HomeController : Controller
    {
        private readonly IMainService _main;
        public HomeController(IMainService main)
        {
            _main = main;
        }

        public IActionResult Home() => View();

        [HttpGet]
        [Route("Register")]
        public IActionResult RegisterByPhone() => View();

        [HttpPost]
        [Route("Register")]
        public IActionResult RegisterByPhone(SignUpVm signUp)
        {
            var result = _main.RegisterUser(signUp);
            if(result == 110)
            {

            }
            return View();
        }

    }
}
