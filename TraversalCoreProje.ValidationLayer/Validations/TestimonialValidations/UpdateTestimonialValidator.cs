using FluentValidation;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class UpdateTestimonialValidator:AbstractValidator<UpdateTestimonialDto>
    {
        public UpdateTestimonialValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("ID alanı boş geçilemez").NotNull().WithMessage("ID alanı boş geçilemez");

            RuleFor(x => x.Comment).NotEmpty().WithMessage("Açıklama alanı boş geçilemez").NotNull().WithMessage("Açıklama alanı boş geçilemez").MinimumLength(50).WithMessage("Lütfen en az 50 karekterlik açıklama bilgisi giriniz").MaximumLength(1500).WithMessage("Lütfen açıklamayı kısaltın");
            RuleFor(x => x.ClientImage).NotEmpty().WithMessage("Lütfen görsel seçiniz").NotNull().WithMessage("Lütfen görsel seçiniz");
            RuleFor(x => x.Client).NotEmpty().WithMessage("Başlık alanı boş geçilemez").NotNull().WithMessage("Başlık alanı boş geçilemez");
        }
    }
}
