using Microsoft.AspNetCore.Mvc;

namespace APIDemo.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
