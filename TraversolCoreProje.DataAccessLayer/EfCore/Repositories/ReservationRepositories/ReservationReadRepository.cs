using Microsoft.EntityFrameworkCore;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Interfaces;
using TraversolCoreProje.DataAccessLayer.Repository;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class ReservationReadRepository : GenericReadRepository<Reservation>, IReservationReadRepository
    {
        private readonly AppDbContext _appDbContext;
        public ReservationReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Reservation>> ApprovalReservation(int id)
        {
            return await _appDbContext.Reservations.Include(x => x.Destination).Include(y=> y.AppUser).AsNoTracking().Where(x=> x.StatusL=="Onay Bekliyor" && x.AppUserId==id).ToListAsync();
        }

        public async Task<List<Reservation>> CurrentReservation(int id)
        {
            return await _appDbContext.Reservations.Include(x => x.Destination).Include(y => y.AppUser).AsNoTracking().Where(x => x.StatusL == "Onaylandı" && x.AppUserId == id).ToListAsync();
        }

        public async Task<List<Reservation>> OldReservation(int id)
        {
            return await _appDbContext.Reservations.Include(x => x.Destination).Include(y => y.AppUser).AsNoTracking().Where(x => x.StatusL == "Geçmiş Rezervasyon" && x.AppUserId == id).ToListAsync();
        }
    }
}
