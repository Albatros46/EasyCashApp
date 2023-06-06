using EasyCashApp.Dto.DTOS.AppUserDtos;
using EasyCashApp.Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashApp.Web.Controllers
{
    public class MyAccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public MyAccountController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        //  [Authorize]//Kullanici giris yapmadan bu sayfaya giris yapamaz
        [HttpGet]
        public async Task<IActionResult> Index()
        {//EasyCashApp.Dto.DTOS.AppUserDtos kullanici bilgilerini goruntulemek ve düzenlemek icin kullancagiz
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserEditDto appUserEditDto = new AppUserEditDto();
            appUserEditDto.FirstName = values.FirstName;
            appUserEditDto.LastName = values.LastName;
            appUserEditDto.PhoneNumber = values.PhoneNumber;
            appUserEditDto.Email = values.Email;
            appUserEditDto.City = values.City;
            appUserEditDto.District = values.Disctrict;
            appUserEditDto.ImgUrl = values.ImageUrl;

            return View(appUserEditDto);
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserEditDto appUserEditDto)
        {
            if (appUserEditDto.Password == appUserEditDto.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.PhoneNumber = appUserEditDto.PhoneNumber;
                user.LastName = appUserEditDto.LastName;
                user.FirstName = appUserEditDto.FirstName;
                user.City = appUserEditDto.City;
                user.Disctrict = appUserEditDto.District;
                user.Email = appUserEditDto.Email;
                user.ImageUrl = "test";
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, appUserEditDto.Password);
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }
    }
}
