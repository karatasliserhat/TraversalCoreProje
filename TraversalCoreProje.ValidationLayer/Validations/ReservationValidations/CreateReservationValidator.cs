using FluentValidation;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class CreateReservationValidator:AbstractValidator<CreateReservationDto>
    {
        public CreateReservationValidator()
        {

            RuleFor(x => x.PersonCount).NotEmpty().WithMessage("Kaç kişi alanı zorunludur").NotNull().WithMessage("Kaç kişi alanı zorunludur");
            RuleFor(x => x.DestinationId).NotEmpty().WithMessage("Lütfen rota seçiniz").NotNull().WithMessage("Lütfen rota seçiniz");
            RuleFor(x => x.AppUserId).NotEmpty().WithMessage("Rezervasyon yapan kişi boş geçilemez").NotNull().WithMessage("Rezervasyon yapan kişi boş geçilemez");
        }
    }
}
