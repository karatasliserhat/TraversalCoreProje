using FluentValidation;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class UpdateVisitorValidator:AbstractValidator<UpdateVisitorDto>
    {
        public UpdateVisitorValidator()
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez").NotNull().WithMessage("Şehir alanı boş geçilemez");

        }
    }
}
