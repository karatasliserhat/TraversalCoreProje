using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Interfaces
{
    public interface IReservationReadRepository:IGenericReadRepository<Reservation>
    {
        Task<List<Reservation>> CurrentReservation(int id);
        Task<List<Reservation>> OldReservation(int id);
        Task<List<Reservation>> ApprovalReservation(int id);

    }
}
