using ECommerce.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Persistence
{
    public class ECommerceDBContext : DbContext
    {
        // Table definitions
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderComment> OrderComments { get; set; }
        public DbSet<User> Users { get; set; }

        // base used for reference for DbContext ctor
        public ECommerceDBContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
            .Property(o => o.Status)
            .HasConversion<int>(); // Enum store as int 

            modelBuilder.Entity<Order>()
            .HasIndex(o => o.AccountId)
            .IsUnique();

            modelBuilder.Entity<Order>()
           .HasIndex(o => o.OrderNumber)
           .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // DB interceptor for create and update times.
            
            // ChangeTracker for tracking changes on entities.
            var entities = ChangeTracker.Entries<BaseEntity>();
            foreach (var entity in entities)
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedAt = DateTime.UtcNow;
                        entity.Entity.IsDeleted = false;
                        break;
                    case EntityState.Modified:
                        entity.Entity.UpdatedAt = DateTime.UtcNow;
                        break;
                    case EntityState.Deleted:
                        entity.Entity.IsDeleted = true;
                        break;
                    default:
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
