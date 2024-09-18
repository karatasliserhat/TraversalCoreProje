using Microsoft.AspNetCore.Http;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.DataAccessLayer.EfCore.Interfaces;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public StatisticsService(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }
        StatisticValueDto StatisticValueDto = new StatisticValueDto();
        public async Task<ResponseDto<int>> DestinationCount()
        {
            return ResponseDto<int>.Success(await _statisticsRepository.DestinationCount(), StatusCodes.Status200OK);
        }

        public async Task<ResponseDto<int>> GuideCount()
        {
            return ResponseDto<int>.Success(await _statisticsRepository.GuideCount(), StatusCodes.Status200OK);
        }

        public async Task<ResponseDto<int>> TestimonialCount()
        {
            return ResponseDto<int>.Success(await _statisticsRepository.TestimonialCount(), StatusCodes.Status200OK);
        }
    }
}
