using Microsoft.AspNetCore.Mvc;

namespace ASPNet_Blog.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
