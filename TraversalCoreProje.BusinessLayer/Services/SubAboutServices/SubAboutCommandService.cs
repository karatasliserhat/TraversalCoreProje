using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class SubAboutCommandService : GenericCommandService<UpdateSubAboutDto, CreateSubAboutDto, SubAbout>, ISubAboutCommandService
    {
        public SubAboutCommandService(IGenericCommandRepository<SubAbout> genericCommandRepository, IMapper mapper) : base(genericCommandRepository, mapper)
        {
        }
    }
}
