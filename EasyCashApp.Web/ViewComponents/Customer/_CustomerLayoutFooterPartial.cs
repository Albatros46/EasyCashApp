using Microsoft.AspNetCore.Mvc;

namespace EasyCashApp.Web.ViewComponents.Customer
{
    public class _CustomerLayoutFooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
   
}
