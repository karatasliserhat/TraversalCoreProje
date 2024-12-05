using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Interfaces
{
    public interface IDestinationReadRepository : IGenericReadRepository<Destination>
    {
        Task<Destination> DestinationwithGuidebyDestinationId(int id);
        Task<List<Destination>> GetLastFourDestinations();
    }
}
