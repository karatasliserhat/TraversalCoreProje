using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IReservationReadService:IGenericReadService<ResultReservationDto,Reservation>
    {
        Task<ResponseDto<List<ResultReservationDto>>> CurrentReservation(int id);
        Task<ResponseDto<List<ResultReservationDto>>> OldReservation(int id);
        Task<ResponseDto<List<ResultReservationDto>>> ApprovalReservation(int id);
    }
}
