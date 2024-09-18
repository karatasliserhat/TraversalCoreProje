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
    public class ReservationReadService : GenericReadService<ResultReservationDto, Reservation>, IReservationReadService
    {
        private readonly IReservationReadRepository _reservationReadRepository;
        private readonly IMapper _mapper;
        public ReservationReadService(IGenericReadRepository<Reservation> genericReadRepository, IMapper mapper, IReservationReadRepository reservationReadRepository) : base(genericReadRepository, mapper)
        {
            _reservationReadRepository = reservationReadRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<ResultReservationDto>>> ApprovalReservation(int id)
        {
            var data = await _reservationReadRepository.ApprovalReservation(id);
            if (data is not null)
            {
                return ResponseDto<List<ResultReservationDto>>.Success(_mapper.Map<List<ResultReservationDto>>(data), StatusCodes.Status200OK);
            }
            return ResponseDto<List<ResultReservationDto>>.Fail("Data Bulunamamadı", StatusCodes.Status404NotFound);
        }

        public async Task<ResponseDto<List<ResultReservationDto>>> CurrentReservation(int id)
        {
            var data = await _reservationReadRepository.CurrentReservation(id);
            if (data is not null)
            {
                return ResponseDto<List<ResultReservationDto>>.Success(_mapper.Map<List<ResultReservationDto>>(data), StatusCodes.Status200OK);
            }
            return ResponseDto<List<ResultReservationDto>>.Fail("Data Bulunamamadı", StatusCodes.Status404NotFound);
        }

        public async Task<ResponseDto<List<ResultReservationDto>>> OldReservation(int id)
        {
            var data = await _reservationReadRepository.OldReservation(id);
            if (data is not null)
            {
                return ResponseDto<List<ResultReservationDto>>.Success(_mapper.Map<List<ResultReservationDto>>(data), StatusCodes.Status200OK);
            }
            return ResponseDto<List<ResultReservationDto>>.Fail("Data Bulunamamadı", StatusCodes.Status404NotFound);
        }
    }
}
