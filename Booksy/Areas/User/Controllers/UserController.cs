using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Booksy.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = "User")]

    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
