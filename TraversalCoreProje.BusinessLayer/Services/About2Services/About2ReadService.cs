using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class About2ReadService : GenericReadService<ResultAbout2Dto, About2>, IAbout2ReadService
    {
        public About2ReadService(IGenericReadRepository<About2> genericReadRepository, IMapper mapper) : base(genericReadRepository, mapper)
        {
        }
    }
}
