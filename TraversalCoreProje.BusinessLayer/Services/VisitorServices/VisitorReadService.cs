using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class VisitorReadService : GenericReadService<ResultVisitorDto, Visitor>, IVisitorReadService
    {
        public VisitorReadService(IGenericReadRepository<Visitor> genericReadRepository, IMapper mapper) : base(genericReadRepository, mapper)
        {
        }
    }
}
