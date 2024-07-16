using Microsoft.AspNetCore.Mvc;

namespace myPortfolio.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
