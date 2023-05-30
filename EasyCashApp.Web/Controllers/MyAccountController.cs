using Microsoft.AspNetCore.Mvc;

namespace EasyCashApp.Web.Controllers
{
    public class MyAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
