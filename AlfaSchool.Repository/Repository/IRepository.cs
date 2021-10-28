using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AlfaSchool.Repository.DbAccess.Model;
using AlfaSchool.Repository.Model;

namespace AlfaSchool.Repository.Repository
{
    interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetByWhere(Expression<Func<T, bool>> func);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entity);
        Task RemoveAsync(Student entity);
        Task<int> SaveChangesAsync();
        Task UpdateAsync(Student entity);
    }
}
