using FluentValidation;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.ValidationLayer
{
    public class UpdateContactUsValidator:AbstractValidator<UpdateContactUsDto>
    {
        public UpdateContactUsValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("ID alanı boş geçilemez").NotNull().WithMessage("ID alanı boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez").NotNull().WithMessage("Ad Soyad  alanı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Lütfen mail adresinzi giriniz").NotNull().WithMessage("Lütfen mail adresinzi giriniz").EmailAddress().WithMessage("Eposta adresiniz uygun formatta değil");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez").NotNull().WithMessage("Konu alanı boş geçilemez");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("İçerik alanı boş geçilemez").NotNull().WithMessage("İçerik alanı boş geçilemez");
        }
    }
}
