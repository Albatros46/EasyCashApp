using EasyCashApp.Dto.DTOS.AppUserDtos;
using EasyCashApp.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashApp.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;//userManager ya IDentityUser sinifi olacak yada onu miras alan bir sinif olmali

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task< IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            if(ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = appUserRegisterDto.UserName,
                    FirstName = appUserRegisterDto.FirstName,
                    LastName = appUserRegisterDto.LastName,
                    Email = appUserRegisterDto.Email,
                };
                var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","ConfirmMail");//Eger girilen mail dogru ise kontrol etmek icin 6 haneli sayi gonderip kontrol etmesini saglayacagiz
                }
               
            }
            return View();
        }
    }
}
