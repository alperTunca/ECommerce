using ECommerce.Core.Application.Repositories;
using ECommerce.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ECommerceDBContext _dbContext;

        public WriteRepository(ECommerceDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DbSet<T> Table => _dbContext.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> eEntry = await Table.AddAsync(entity);
            return eEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> entities)
        {
            await Table.AddRangeAsync(entities);
            return true;
        }

        public bool Remove(T entity)
        {
            EntityEntry<T> eEntry = Table.Remove(entity);
            return eEntry.State == EntityState.Deleted;
        }
        public bool RemoveRange(List<T> entities)
        {
            Table.RemoveRange(entities);
            return true;
        }

        public async Task<bool> Remove(int id)
        {
            var entity = await Table.FirstOrDefaultAsync(x => x.Id == id);
            return Remove(entity);
        }

        public bool Update(T entity)
        {
            EntityEntry<T> eEntry = Table.Update(entity);
            return eEntry.State == EntityState.Modified;
        }

        public Task<int> SaveAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}
