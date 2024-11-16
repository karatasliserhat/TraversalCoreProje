using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Interfaces
{
    public interface IBookingExchangeReadApiServices
    {
        Task<ResultBookingExchangeViewModel> BookingExchangeList();
    }
}
