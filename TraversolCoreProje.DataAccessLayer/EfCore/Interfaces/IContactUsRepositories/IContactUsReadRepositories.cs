using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Interfaces.IContactUsRepositories
{
    public interface IContactUsReadRepositories:IGenericReadRepository<ContactUs>
    {
        Task<List<ContactUs>> GetlistContactUsByStatusTrue();
        Task<List<ContactUs>> GetlistContactUsByStatusFalse();
        Task GetlistContactUsChangeFalse(int id);
    }
}
