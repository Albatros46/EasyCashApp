using Microsoft.AspNetCore.Mvc;

namespace EasyCashApp.Web.Controllers
{
    public class CustomerLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
