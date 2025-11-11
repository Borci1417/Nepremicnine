using Microsoft.AspNetCore.Mvc;

namespace RZ_nepremicnine.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}