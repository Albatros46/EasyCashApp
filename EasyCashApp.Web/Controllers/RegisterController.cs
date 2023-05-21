using EasyCashApp.Dto.DTOS.AppUserDtos;
using EasyCashApp.Entity.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace EasyCashApp.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;//userManager ya IDentityUser sinifi olacak yada onu miras alan bir sinif olmali
                                                           //.Net Core Identity kütüphanesnin password kombänayonu en az 1 sayi 1 harf 1 sembol ve en az 6 karakterden olusmali

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            if(ModelState.IsValid)
            {
                Random random = new Random();
                int code;
                code = random.Next(100000, 1000000);
                AppUser appUser = new AppUser()
                {
                    UserName = appUserRegisterDto.UserName,
                    FirstName = appUserRegisterDto.FirstName,
                    LastName = appUserRegisterDto.LastName,
                    Email = appUserRegisterDto.Email,
                    City="Pforzheim",
                    Disctrict="Test1",
                    ImageUrl="TestImg1",
                    ConfirmCode=code,//6 haneli sayi uretecek. Email confirm icin 
                };
                var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);
                if (result.Succeeded)
                {
                    MimeMessage mineMessage=new MimeMessage();//MailKit paketi ekelndikten sonra nuget pagetten maile gonderilecek 6 haneli kod icin kullnacagiz
                    MailboxAddress mailboxAdressfrom=new MailboxAddress("Easy Cash Admin", "srvt46kcdg@gmail.com");//veya "Easy Cash Admin",kendi mail adresimiz
                    MailboxAddress mailboxAdressTo = new MailboxAddress("User", appUser.Email);
                    mineMessage.From.Add(mailboxAdressfrom);
                    mineMessage.To.Add(mailboxAdressTo);

                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.TextBody = "Kayit islemi icin mailinizi onaylayiniz:" + code;
                    mineMessage.Body=bodyBuilder.ToMessageBody();
                    mineMessage.Subject = "Easy Cash Onay Kodu";

                    SmtpClient client = new SmtpClient();
                    client.Connect("smtp.gmail.com",587, false);//türkiye icin 587 google hesabinizi iki adimda dogrulamaya acmaniz gerekli aksi halde hata veriyor.
                    client.Authenticate("srvt46kcdg@gmail.com", "udjqqtbnznkrswbb");//gamil iki faktor sifreyi actiktan sonra uygulama sifresi olusturuyoruz oradan alip buraya yapistirdik
                    client.Send(mineMessage);
                    client.Disconnect(true);

                    TempData["Mail"]=appUserRegisterDto.Email;//TempData baska bir alana veri tasima yontemidir.
                    return RedirectToAction("Index","ConfirmMail");//Eger girilen mail dogru ise kontrol etmek icin 6 haneli sayi gonderip kontrol etmesini saglayacagiz
                }
                else
                {
                    foreach (var item in result.Errors)
                    {//Register alaninda giris yapildiginda hatayi yakalayip kullaniciya göstermek icin.
                        ModelState.AddModelError("", item.Description);
                    }
                }
               
            }
            return View();
        }
    }
}
