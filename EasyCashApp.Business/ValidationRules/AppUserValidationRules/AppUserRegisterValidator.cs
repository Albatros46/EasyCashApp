using EasyCashApp.Dto.DTOS.AppUserDtos;
using FluentValidation;

namespace EasyCashApp.Business.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x=>x.FirstName).NotEmpty().WithMessage("Bu alan bos gecilemez!");
            RuleFor(x=>x.LastName).NotEmpty().WithMessage("Bu alan bos gecilemez!");
            RuleFor(x=>x.UserName).NotEmpty().WithMessage("Bu alan bos gecilemez!");
            RuleFor(x=>x.Email).NotEmpty().WithMessage("Bu alan bos gecilemez!");
            RuleFor(x=>x.Email).EmailAddress().WithMessage("Bu alan email adresi olmak zorunda!");
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Bu alan bos gecilemez!");
            RuleFor(x=>x.Password).MinimumLength(6).WithMessage("En az 6 karakter giriniz!");
            RuleFor(x=>x.ConfirmPassword).NotEmpty().WithMessage("Bu alan bos gecilemez!");
            RuleFor(x => x.ConfirmPassword).MinimumLength(6).WithMessage("En az 6 karakter giriniz!");
            RuleFor(x=>x.ConfirmPassword).Matches(x=>x.Password).WithMessage("Parola eslesmiyor!");
          //  RuleFor(x=>x.ConfirmPassword).Equals(x=>x.Password).WithMessage("Parola eslesmiyor!");
        }
    }
}
