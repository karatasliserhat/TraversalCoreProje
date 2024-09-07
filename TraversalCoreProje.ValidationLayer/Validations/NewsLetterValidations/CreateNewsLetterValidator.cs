using FluentValidation;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class CreateNewsLetterValidator:AbstractValidator<CreateNewsLetterDto>
    {
        public CreateNewsLetterValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez").NotNull().WithMessage("Mail alanı boş geçilemez").EmailAddress().WithMessage("Eposta adresi geçerli formatta değil");
        }
    }
}
