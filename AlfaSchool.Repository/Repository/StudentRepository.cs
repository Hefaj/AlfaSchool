using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AlfaSchool.Repository.DbAccess;
using AlfaSchool.Repository.DbAccess.Model;
using Microsoft.EntityFrameworkCore;
using AlfaSchool.Repository.Model;

namespace AlfaSchool.Repository.Repository
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly DataContext _context;

        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Student> Get(Guid entityId)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.Id == entityId);
        }
        
        public IQueryable<Student> GetAll()
        {
            return _context.Students.AsNoTracking();
        }

        public IQueryable<Student> GetByWhere(Expression<Func<Student, bool>> func)
        {   
            return _context.Students.Where(func).AsNoTracking();
        }

        public async Task AddAsync(Student entity)
        {
            await _context.Students.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<Student> entity)
        {
            await _context.Students.AddRangeAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(Student entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Student entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
