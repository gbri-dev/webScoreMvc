using Microsoft.AspNetCore.Mvc;

namespace WebScore.Controllers
{
    public class NewlettersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Newletter()
        {
            ViewBag.Title = "New Letters";
            return View();
        }
    }
}
