using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class ReservationReadApiService : BaseReadApiService<ResultReservationViewModel>, IReservationReadApiService
    {
        public ReservationReadApiService(HttpClient httpClient, IUserService userService) : base(httpClient, userService)
        {
        }
    }
}
