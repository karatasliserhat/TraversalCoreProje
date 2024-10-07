using FluentValidation;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class CreateGuideValidator:AbstractValidator<CreateGuideDto>
    {
        public CreateGuideValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez").NotNull().WithMessage("Açıklama alanı boş geçilemez").MinimumLength(10).WithMessage("Lütfen en az 10 karekterlik açıklama bilgisi giriniz").MaximumLength(1500).WithMessage("Lütfen açıklamayı kısaltın");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen görsel seçiniz").NotNull().WithMessage("Lütfen görsel seçiniz");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez").NotNull().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.TwitterUrl).NotEmpty().WithMessage("Twitter Url alanı boş geçilemez").NotNull().WithMessage("BTwitter Url boş geçilemez");
            RuleFor(x => x.InstagramUrl).NotEmpty().WithMessage("Instagram Url alanı boş geçilemez").NotNull().WithMessage("Instagram Url alanı boş geçilemez");
        }
    }
}
