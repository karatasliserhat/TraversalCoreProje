using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class GuideCommandService : GenericCommandService<UpdateGuideDto, CreateGuideDto, Guide>, IGuideCommandService
    {
        public GuideCommandService(IGenericCommandRepository<Guide> genericCommandRepository, IMapper mapper) : base(genericCommandRepository, mapper)
        {
        }
    }
}
