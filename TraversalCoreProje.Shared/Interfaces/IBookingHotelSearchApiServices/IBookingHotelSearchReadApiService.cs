using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Interface { 
    public interface IBookingHotelSearchReadApiService
    {
        Task<ResultBookingHotelViewModel> GetAllBookingHotelList();
    }
}
