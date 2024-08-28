using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class FeatureCommandService : GenericCommandService<UpdateFeatureDto, CreateFeatureDto, Feature>, IFeatureCommandService
    {
        public FeatureCommandService(IGenericCommandRepository<Feature> genericCommandRepository, IMapper mapper) : base(genericCommandRepository, mapper)
        {
        }
    }
}
