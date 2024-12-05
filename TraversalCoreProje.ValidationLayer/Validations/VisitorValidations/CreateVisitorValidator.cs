using FluentValidation;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class CreateVisitorValidator:AbstractValidator<CreateVisitorDto>
    {
        public CreateVisitorValidator()
        {

           
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez").NotNull().WithMessage("Şehir alanı boş geçilemez");
            
        }
    }
}
