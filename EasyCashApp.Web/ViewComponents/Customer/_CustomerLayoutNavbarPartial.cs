using Microsoft.AspNetCore.Mvc;

namespace EasyCashApp.Web.ViewComponents.Customer
{
    public class _CustomerLayoutNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
   
}
