using Microsoft.AspNetCore.Identity;

namespace EasyCashApp.Web.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{//HAtalarin türkcelestirilmesi icin kullanacagiz.
	 // kisinin mail adresine 6 haneli kod gonderecegiz mail dogrulandiktan sonra aktif hale gelecek
	 // Türkce hata mesajlari yazildiktan sonra program.cs tarafinda kullanima hazilamaliyiz.
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Parola en az {length} karakter olmalidir!"
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = "Lütfen en az 1 büyük harf giriniz!"
			};
		}
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = "En az 1 kücük karakter giriniz!"
			};
		}
		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresDigit",
				Description = "En az bir tane sayi giriniz!"
			};
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Lütfen bir tane sembol giriniz!"
			};
		}

	}
}
