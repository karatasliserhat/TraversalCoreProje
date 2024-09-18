using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class ReservationCommandService : GenericCommandService<UpdateReservationDto, CreateReservationDto, Reservation>, IReservationCommandService
    {
        public ReservationCommandService(IGenericCommandRepository<Reservation> genericCommandRepository, IMapper mapper) : base(genericCommandRepository, mapper)
        {
        }
    }
}
