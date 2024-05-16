using ECommerce.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity // BaseEntity used instead of class for DB processes
    {
        DbSet<T> Table { get; }
    }
}
