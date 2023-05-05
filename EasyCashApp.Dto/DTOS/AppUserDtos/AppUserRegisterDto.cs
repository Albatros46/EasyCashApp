using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashApp.Dto.DTOS.AppUserDtos
{
    public class AppUserRegisterDto
    {//Türkce hata kodlarini EasyCashApp.Business.ValidationRules.AppUserValidationRules icindeki
     //AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto> FluentValidation Kullnaranrak yazdim.
        [Required(ErrorMessage = "Dieses Feld ist obligatorisch!")]
        [Display(Name ="Vorname")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Dieses Feld ist obligatorisch!")]
        [Display(Name = "Nachname")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Dieses Feld ist obligatorisch!")]
        [Display(Name = "Benutzername")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Dieses Feld ist obligatorisch!")]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Dieses Feld ist obligatorisch!")]
        [Display(Name = "Kennwort")]
        [MinLength(6,ErrorMessage = "Sie müssen mindestens 6 Zeichen schreiben!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Dieses Feld ist obligatorisch!")]
        [Display(Name = "Bestätigung des Kennworts")]
        [MinLength(6,ErrorMessage = "Sie müssen mindestens 6 Zeichen schreiben!")]
        public string ConfirmPassword { get; set; }
    }
    //Ad,Soyad,username, mail, password, confirmpassword
}
