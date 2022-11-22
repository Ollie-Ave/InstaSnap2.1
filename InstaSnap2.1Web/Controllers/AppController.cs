using Microsoft.AspNetCore.Mvc;

namespace InstaSnap2._1Web.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
