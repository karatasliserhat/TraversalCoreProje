using FluentValidation;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class CreateFeature2Validator:AbstractValidator<CreateFeature2Dto>
    {
        public CreateFeature2Validator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez").NotNull().WithMessage("Açıklama alanı boş geçilemez").MinimumLength(50).WithMessage("Lütfen en az 50 karekterlik açıklama bilgisi giriniz").MaximumLength(1500).WithMessage("Lütfen açıklamayı kısaltın");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen görsel seçiniz").NotNull().WithMessage("Lütfen görsel seçiniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez").NotNull().WithMessage("Başlık alanı boş geçilemez");
        }
    }
}
