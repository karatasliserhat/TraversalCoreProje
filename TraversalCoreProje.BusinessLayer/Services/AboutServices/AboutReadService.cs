using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class AboutReadService : GenericReadService<ResultAboutDto, About>, IAboutReadService
    {
        public AboutReadService(IGenericReadRepository<About> genericReadRepository, IMapper mapper) : base(genericReadRepository, mapper)
        {
        }
    }
}
