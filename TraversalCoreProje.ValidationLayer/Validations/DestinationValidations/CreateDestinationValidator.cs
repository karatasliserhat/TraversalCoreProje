using FluentValidation;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class CreateDestinationValidator:AbstractValidator<CreateDestinationDto>
    {
        public CreateDestinationValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez").NotNull().WithMessage("Açıklama alanı boş geçilemez").MinimumLength(50).WithMessage("Lütfen en az 50 karekterlik açıklama bilgisi giriniz").MaximumLength(1500).WithMessage("Lütfen açıklamayı kısaltın");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen görsel seçiniz").NotNull().WithMessage("Lütfen görsel seçiniz");
            RuleFor(x => x.City).NotEmpty().WithMessage("Başlık alanı boş geçilemez").NotNull().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(x => x.DayNight).NotEmpty().WithMessage("Kaç Gece alanı boş geçilemez").NotNull().WithMessage("Kaç Gece alanı boş geçilemez");
            RuleFor(x => x.Capacity).NotEmpty().WithMessage("Kapasite alanı boş geçilemez").NotNull().WithMessage("Kapasite alanı boş geçilemez");
        }
    }
}
