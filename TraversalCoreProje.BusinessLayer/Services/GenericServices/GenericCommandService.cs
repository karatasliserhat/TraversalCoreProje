using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.BaseConcrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class GenericCommandService<UpdateDto, CreateDto, Entity> : IGenericCommandService<UpdateDto, CreateDto, Entity> where UpdateDto : UpdateBaseDto where CreateDto : CreateBaseDto where Entity : BaseEntity
    {
        private readonly IGenericCommandRepository<Entity> _genericCommandRepository;
        private readonly IMapper _mapper;
        public GenericCommandService(IGenericCommandRepository<Entity> genericCommandRepository, IMapper mapper)
        {
            _genericCommandRepository = genericCommandRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(CreateDto entity)
        {
            await _genericCommandRepository.CreateAsync(_mapper.Map<Entity>(entity));
        }

        public async Task DeleteAsync(int id)
        {
            await _genericCommandRepository.DeleteAsync(id);
        }

        public async Task UpdateAsync(UpdateDto entity)
        {
            await _genericCommandRepository.UpdateAsync(_mapper.Map<Entity>(entity));
        }
    }
}
