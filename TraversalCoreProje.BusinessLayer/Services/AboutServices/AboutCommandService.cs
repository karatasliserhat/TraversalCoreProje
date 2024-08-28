using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class AboutCommandService : GenericCommandService<UpdateAboutDto, CreateAboutDto, About>, IAboutCommandService
    {
        public AboutCommandService(IGenericCommandRepository<About> genericCommandRepository, IMapper mapper) : base(genericCommandRepository, mapper)
        {
        }
    }
}
