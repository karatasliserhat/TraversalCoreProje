using FluentValidation;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class MailRequestViewModelValidator : AbstractValidator<MailRequestViewModel>
    {
        public MailRequestViewModelValidator()
        {
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı Boş Geçilemez").NotNull().WithMessage("Konu Alanı Boş Geçilemez");
            RuleFor(x => x.Body).NotEmpty().WithMessage("İçerik alanı Boş Geçilemez").NotNull().WithMessage("İçerik Alanı Boş Geçilemez");
            RuleFor(x => x.ReceiverMail).EmailAddress().WithMessage("Mail Adresi Uygun Formatta Değil").NotEmpty().WithMessage("Mail Adresi Boş Geçilemez").NotNull().WithMessage("Mail Adresi Boş Geçilemez");
        }
    }
}
