using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class SubAboutReadService : GenericReadService<ResultSubAboutDto, SubAbout>, ISubAboutReadService
    {
        public SubAboutReadService(IGenericReadRepository<SubAbout> genericReadRepository, IMapper mapper) : base(genericReadRepository, mapper)
        {
        }
    }
}
