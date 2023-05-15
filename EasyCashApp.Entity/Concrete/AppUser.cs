using Microsoft.AspNetCore.Identity;

namespace EasyCashApp.Entity.Concrete
{
    public class AppUser:IdentityUser<int>
    {//Normal sartlarda IdentityUSer de key türü string bu <int> kullanim ile tur int olarak degistrildi.
     //Ayrica rol tablosunda da key degeri degistirilmeli
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Disctrict { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public int ConfirmCode { get; set; }//Mail e gonderilecek 6 haneli kod icin. Random bir sayi üretecek
        public List<CustomerAccount> CustomerAccounts { get; set; }//One to Many 
    }
}
