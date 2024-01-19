using Microsoft.AspNetCore.Mvc;

namespace Vicky.Controllers
{
    public class VIckyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
