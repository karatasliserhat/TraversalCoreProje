using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class FeatureReadService : GenericReadService<ResultFeatureDto, Feature>, IFeatureReadService
    {
        public FeatureReadService(IGenericReadRepository<Feature> genericReadRepository, IMapper mapper) : base(genericReadRepository, mapper)
        {
        }
    }
}
