using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Testing.Domain.Entities;
using Testing.Infrastructure.Interfaces;

namespace Testing.Infrastructure.Implements
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected TestingDbContext _erpContext { get; set; }
        internal DbSet<T> dbSet;
        public readonly ILogger _logger;

        public RepositoryBase(
            TestingDbContext context,
            ILogger logger)
        {
            this._erpContext = context;
            this.dbSet = context.Set<T>();
            _logger = logger;
        }

        public virtual async Task<T> GetById(Guid id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual async Task<T> Add(T entity)
        {
            await dbSet.AddAsync(entity);
            return entity;
        }

        public virtual Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<T>> All()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }

        public virtual Task<bool> Upsert(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
