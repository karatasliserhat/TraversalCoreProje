using FluentValidation;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class UpdateContactValidator:AbstractValidator<UpdateContactDto>
    {
        public UpdateContactValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("ID alanı boş geçilemez").NotNull().WithMessage("ID alanı boş geçilemez");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez").NotNull().WithMessage("Açıklama alanı boş geçilemez").MinimumLength(50).WithMessage("Lütfen en az 50 karekterlik açıklama bilgisi giriniz").MaximumLength(1500).WithMessage("Lütfen açıklamayı kısaltın");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Lütfen mail adresinzi giriniz").NotNull().WithMessage("Lütfen mail adresinzi giriniz").EmailAddress().WithMessage("Eposta adresiniz uygun formatta değil");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres alanı boş geçilemez").NotNull().WithMessage("Adres alanı boş geçilemez");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon alanı boş geçilemez").NotNull().WithMessage("Telefon alanı boş geçilemez");
            RuleFor(x => x.MapLocation).NotEmpty().WithMessage("Harita Lokasyon alanı boş geçilemez").NotNull().WithMessage("Harita Lokasyon alanı boş geçilemez");
        }
    }
}
