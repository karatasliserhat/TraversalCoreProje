using FluentValidation;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class CreateVisitorValidator:AbstractValidator<CreateVisitorDto>
    {
        public CreateVisitorValidator()
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez").NotNull().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("SoyAd alanı boş geçilemez").NotNull().WithMessage("SoyAd alanı boş geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez").NotNull().WithMessage("Şehir alanı boş geçilemez");
            RuleFor(x => x.Country).NotEmpty().WithMessage("İlçe alanı boş geçilemez").NotNull().WithMessage("İlçe alanı boş geçilemez");
            RuleFor(x => x.Country).NotEmpty().WithMessage("İlçe alanı boş geçilemez").NotNull().WithMessage("İlçe alanı boş geçilemez");
            RuleFor(x => x.Mail).EmailAddress().WithMessage("Mail Adresi Uygun Formatta Değil").NotEmpty().WithMessage("Mail Adresi Boş Geçilemez").NotNull().WithMessage("Mail Adresi Boş Geçilemez");
        }
    }
}
