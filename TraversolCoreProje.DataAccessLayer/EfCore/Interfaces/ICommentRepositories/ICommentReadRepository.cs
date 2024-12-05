using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Interfaces
{
    public interface ICommentReadRepository:IGenericReadRepository<Comment>
    {
        Task<List<Comment>> CommentAllWithDestinationCityIncludeAsync();
        Task<List<Comment>> CommentAllWithAsppUserIncludeByIdAsync(int destinationId);
    }
}
