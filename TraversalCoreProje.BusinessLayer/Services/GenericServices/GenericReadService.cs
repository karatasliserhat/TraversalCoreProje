using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.BaseConcrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class GenericReadService<ResultDto, Entity> : IGenericReadService<ResultDto, Entity> where ResultDto : ResultBaseDto where Entity : BaseEntity
    {
        private readonly IGenericReadRepository<Entity> _genericReadRepository;
        private readonly IMapper _mapper;
        public GenericReadService(IGenericReadRepository<Entity> genericReadRepository, IMapper mapper)
        {
            _genericReadRepository = genericReadRepository;
            _mapper = mapper;
        }

        public async Task<ResultDto> GetByIdAsync(int id)
        {
            var data = _mapper.Map<ResultDto>(await _genericReadRepository.GetByIdAsync(id));
            return data;
        }

        public async Task<List<ResultDto>> GetListAsync()
        {
            var data = _mapper.Map<List<ResultDto>>(await _genericReadRepository.GetListAsync());
            return data;
        }
    }
}
