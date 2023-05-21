using EasyCashApp.Entity.Concrete;
using EasyCashApp.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashApp.Web.Controllers
{
    public class ConfirmMailController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ConfirmMailController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public  IActionResult Index()
        {//MAil adersini onaylamak icin kullancagiz. Mail adresine gonderilen 6 haneli kodu burada isteyerek onaylayacagiz.
            var value = TempData["Mail"];//registercontroller deki veriyi buraya tasimak icin kullanacagiz
            ViewBag.v1 = value;
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ConfirmMailViewModel confirmMailViewModel)
        {//Bu kisim viewModel e bagli olmak zorunda geri deger donecegi icin.
            
            var user = await _userManager.FindByEmailAsync(confirmMailViewModel.Mail.ToString());
            if (user.ConfirmCode==confirmMailViewModel.ConfirmCode)
            {
                return RedirectToAction("Index", "MyProfile");//Kullanici kendi profil sayfasina yonlendirilecek MyProfileController-->Index.cshtml
            }
            return View();
        }
    }
}
