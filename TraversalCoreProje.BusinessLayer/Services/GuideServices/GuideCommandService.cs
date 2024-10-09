using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.EfCore.Interfaces;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class GuideCommandService : GenericCommandService<UpdateGuideDto, CreateGuideDto, Guide>, IGuideCommandService
    {
        private readonly IGuideCommandRepository _guideCommandRepository;
        public GuideCommandService(IGenericCommandRepository<Guide> genericCommandRepository, IMapper mapper, IGuideCommandRepository guideCommandRepository) : base(genericCommandRepository, mapper)
        {
            _guideCommandRepository = guideCommandRepository;
        }

        public async Task<ResponseDto<NoContent>> GuideStatusFalseAsync(int id)
        {
            await _guideCommandRepository.GuideStatusFalse(id);
            return ResponseDto<NoContent>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<ResponseDto<NoContent>> GuideStatusTrueAsync(int id)
        {
            await _guideCommandRepository.GuideStatusTrue(id);
            return ResponseDto<NoContent>.Success(StatusCodes.Status204NoContent);
        }
    }
}
