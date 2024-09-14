using FluentValidation;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class UpdateUserViewModelValidation:AbstractValidator<UserEditViewModel>
    {
        public UpdateUserViewModelValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı Boş Geçilemez").NotNull().WithMessage("Ad Alanı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı Boş Geçilemez").NotNull().WithMessage("Soyad Alanı Boş Geçilemez");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı alanı Boş Geçilemez").NotNull().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Mail Adresiniz Uygun Formatta Değil").NotEmpty().WithMessage("Mail Adresi Boş Geçilemez").NotNull().WithMessage("Mail Adresi Boş Geçilemez");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Şifreler Uyuşmamaktadır");
        }
    }
}
