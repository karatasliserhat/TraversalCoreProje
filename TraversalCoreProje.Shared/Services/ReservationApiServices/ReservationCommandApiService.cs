using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class ReservationCommandApiService : BaseCommandApiService<UpdateReservationViewModel, CreateReservationViewModel>, IReservationCommandApiService
    {
        public ReservationCommandApiService(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
