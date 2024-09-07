using FluentValidation;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class SignInViewModelValidator:AbstractValidator<SignInViewModel>
    {
        public SignInViewModelValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez").NotNull().WithMessage("Şifre Alanı Boş Geçilemez");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Mail Adresiniz Uygun Formatta Değil").NotEmpty().WithMessage("Mail Adresi Boş Geçilemez").NotNull().WithMessage("Mail Adresi Boş Geçilemez");
        }
    }
}
