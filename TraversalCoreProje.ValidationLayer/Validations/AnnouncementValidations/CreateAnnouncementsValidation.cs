using FluentValidation;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.ValidationLayer.Validations.AnnouncementValidations
{
    public class CreateAnnouncementsValidation : AbstractValidator<CreateAnnouncementDto>
    {
        public CreateAnnouncementsValidation()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez").NotNull().WithMessage("Başlık alanı boş geçilemez").MinimumLength(10).WithMessage("Lütfen en az 10 karekterlik başlık bilgisi giriniz").MaximumLength(50).WithMessage("Lütfen en fazla 50 karekterlik başlık giriniz");
            RuleFor(x => x.Content).NotEmpty().WithMessage("içerik alanı boş geçilemez").NotNull().WithMessage("içerik alanı boş geçilemez").MinimumLength(50).WithMessage("Lütfen en az 50 karekterlik içerik bilgisi giriniz").MaximumLength(500).WithMessage("Lütfen en fazla 500 karekterlik içerik giriniz");
        }
    }
}
