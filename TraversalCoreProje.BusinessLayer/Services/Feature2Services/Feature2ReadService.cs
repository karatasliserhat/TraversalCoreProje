using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class Feature2ReadService : GenericReadService<ResultFeature2Dto, Feature2>, IFeature2ReadService
    {
        public Feature2ReadService(IGenericReadRepository<Feature2> genericReadRepository, IMapper mapper) : base(genericReadRepository, mapper)
        {
        }
    }
}
