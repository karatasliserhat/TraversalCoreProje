﻿using Microsoft.EntityFrameworkCore;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Interfaces;
using TraversolCoreProje.DataAccessLayer.Repository;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class CommentReadRepository : GenericReadRepository<Comment>, ICommentReadRepository
    {
        private readonly AppDbContext _appDbContext;
        public CommentReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Comment>> CommentAllWithAsppUserIncludeByIdAsync(int destinationId)
        {
            return await _appDbContext.Comments.Include(x => x.AppUser).Where(x=> x.DestinationId==destinationId).AsNoTracking().ToListAsync();
        }

        public async Task<List<Comment>> CommentAllWithDestinationCityIncludeAsync()
        {
            return await _appDbContext.Comments.Include(x => x.Destination).Include(x=> x.AppUser).AsNoTracking().ToListAsync();
        }
    }
}
