using Microsoft.AspNetCore.Mvc;

namespace myPortfolio.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
