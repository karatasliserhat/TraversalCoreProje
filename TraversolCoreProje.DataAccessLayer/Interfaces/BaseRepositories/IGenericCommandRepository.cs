using TraversalCoreProje.CoreLayer.BaseConcrete;

namespace TraversolCoreProje.DataAccessLayer.Interfaces
{
    public interface IGenericCommandRepository<T> where T:BaseEntity
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
