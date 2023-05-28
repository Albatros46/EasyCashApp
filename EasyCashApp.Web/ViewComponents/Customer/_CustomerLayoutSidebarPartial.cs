using Microsoft.AspNetCore.Mvc;

namespace EasyCashApp.Web.ViewComponents.Customer
{
    public class _CustomerLayoutSidebarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
