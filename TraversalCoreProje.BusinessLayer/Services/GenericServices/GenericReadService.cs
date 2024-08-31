using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.Net;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.BaseConcrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

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

        public async Task<ResponseDto<ResultDto>> GetByIdAsync(int id)
        {
            var data = _mapper.Map<ResultDto>(await _genericReadRepository.GetByIdAsync(id));
            if (data is not null)
                return ResponseDto<ResultDto>.Success(data, StatusCodes.Status200OK);
            return ResponseDto<ResultDto>.Fail("Kayıt Bulunamadı", StatusCodes.Status204NoContent);
        }

        public async Task<ResponseDto<List<ResultDto>>> GetListAsync()
        {
            var data = _mapper.Map<List<ResultDto>>(await _genericReadRepository.GetListAsync());
            if (data is { Count: > 0 })
                return ResponseDto<List<ResultDto>>.Success(data, StatusCodes.Status200OK);
            return ResponseDto<List<ResultDto>>.Fail("Data Yok", StatusCodes.Status204NoContent);
        }
    }
}
