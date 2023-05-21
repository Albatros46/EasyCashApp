using Microsoft.AspNetCore.Mvc;

namespace EasyCashApp.Web.Controllers
{
    public class MyProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
