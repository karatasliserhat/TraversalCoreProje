using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class GuideReadService : GenericReadService<ResultGuideDto, Guide>, IGuideReadService
    {
        public GuideReadService(IGenericReadRepository<Guide> genericReadRepository, IMapper mapper) : base(genericReadRepository, mapper)
        {
        }
    }
}
