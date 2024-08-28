using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class DestinationReadService : GenericReadService<ResultDestinationDto, Destination>, IDestinationReadService
    {
        public DestinationReadService(IGenericReadRepository<Destination> genericReadRepository, IMapper mapper) : base(genericReadRepository, mapper)
        {
        }
    }
}
