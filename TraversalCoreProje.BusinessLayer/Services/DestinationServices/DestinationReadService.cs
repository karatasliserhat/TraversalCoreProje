using AutoMapper;
using Microsoft.AspNetCore.Http;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.EfCore.Interfaces;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class DestinationReadService : GenericReadService<ResultDestinationDto, Destination>, IDestinationReadService
    {
        private readonly IDestinationReadRepository _destinationReadRepository;
        private readonly IMapper _mapper;
        public DestinationReadService(IGenericReadRepository<Destination> genericReadRepository, IMapper mapper, IDestinationReadRepository destinationReadRepository) : base(genericReadRepository, mapper)
        {
            _mapper = mapper;
            _destinationReadRepository = destinationReadRepository;
        }

        public async Task<ResponseDto<ResultDestinationDto>> DestinationwithGuidebyDestinationId(int id)
        {
            var result = _mapper.Map<ResultDestinationDto>(await _destinationReadRepository.DestinationwithGuidebyDestinationId(id));
            return ResponseDto<ResultDestinationDto>.Success(result, StatusCodes.Status200OK);
        }

        public async Task<ResponseDto<List<ResultDestinationDto>>> GetLastFourDestinationIdAsync()
        {
            var result = _mapper.Map<List<ResultDestinationDto>>(await _destinationReadRepository.GetLastFourDestinations());
            return ResponseDto<List<ResultDestinationDto>>.Success(result, StatusCodes.Status200OK);
        }
    }
}
