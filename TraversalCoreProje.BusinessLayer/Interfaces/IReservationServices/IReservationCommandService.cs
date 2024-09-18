using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IReservationCommandService : IGenericCommandService<UpdateReservationDto, CreateReservationDto, Reservation>
    {
    }
}
