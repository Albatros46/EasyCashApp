using Microsoft.AspNetCore.Mvc;

namespace EasyCashApp.Web.ViewComponents.Customer
{
    public class _CustomerLayoutScriptsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
