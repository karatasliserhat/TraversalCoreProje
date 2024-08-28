using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class Feature2CommandService : GenericCommandService<UpdateFeature2Dto, CreateFeature2Dto, Feature2>, IFeature2CommandService
    {
        public Feature2CommandService(IGenericCommandRepository<Feature2> genericCommandRepository, IMapper mapper) : base(genericCommandRepository, mapper)
        {
        }
    }
}
