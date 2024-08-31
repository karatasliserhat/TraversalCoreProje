using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.BaseConcrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

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

        public async Task<ResponseDto<NoContent>> CreateAsync(CreateDto entity)
        {
            await _genericCommandRepository.CreateAsync(_mapper.Map<Entity>(entity));
            return ResponseDto<NoContent>.Success(StatusCodes.Status201Created);
        }

        public async Task<ResponseDto<NoContent>> DeleteAsync(int id)
        {
            await _genericCommandRepository.DeleteAsync(id);
            return ResponseDto<NoContent>.Success(StatusCodes.Status204NoContent);

        }

        public async Task<ResponseDto<NoContent>> UpdateAsync(UpdateDto entity)
        {
            await _genericCommandRepository.UpdateAsync(_mapper.Map<Entity>(entity));
            return ResponseDto<NoContent>.Success(StatusCodes.Status204NoContent);
        }
    }
}
