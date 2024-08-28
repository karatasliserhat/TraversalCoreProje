using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class DestinationCommandService : GenericCommandService<UpdateDestinationDto, CreateDestinationDto, Destination>, IDestinationCommandService
    {
        public DestinationCommandService(IGenericCommandRepository<Destination> genericCommandRepository, IMapper mapper) : base(genericCommandRepository, mapper)
        {
        }
    }
}
