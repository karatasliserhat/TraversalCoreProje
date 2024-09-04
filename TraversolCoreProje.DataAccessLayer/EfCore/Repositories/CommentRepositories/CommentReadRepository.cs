using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Intercaces;
using TraversolCoreProje.DataAccessLayer.Repository;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class CommentReadRepository : GenericReadRepository<Comment>, ICommentReadRepository
    {
        private readonly AppDbContext _apdb;
        public CommentReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _apdb = appDbContext;
        }
    }
}
