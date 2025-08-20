using Microsoft.AspNetCore.Mvc;

namespace Demo_Project.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            // This action method will return the default view for the Profile page.
            return View();
        }
    }
}
