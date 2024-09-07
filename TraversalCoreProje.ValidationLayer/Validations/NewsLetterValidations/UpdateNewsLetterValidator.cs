using FluentValidation;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class UpdateNewsLetterValidator : AbstractValidator<UpdateNewsLetterDto>
    {
        public UpdateNewsLetterValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("ID alanı boş geçilemez").NotNull().WithMessage("ID alanı boş geçilemez");

            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez").NotNull().WithMessage("Mail alanı boş geçilemez").EmailAddress().WithMessage("Eposta adresi geçerli formatta değil");
        }
    }
}
