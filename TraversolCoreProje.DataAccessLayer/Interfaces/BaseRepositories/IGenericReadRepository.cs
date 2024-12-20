﻿using System.Linq.Expressions;
using TraversalCoreProje.CoreLayer.BaseConcrete;

namespace TraversolCoreProje.DataAccessLayer.Interfaces
{
    public interface IGenericReadRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetListAsync();
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetListByFilter(Expression<Func<T, bool>> filter);
    }
}
