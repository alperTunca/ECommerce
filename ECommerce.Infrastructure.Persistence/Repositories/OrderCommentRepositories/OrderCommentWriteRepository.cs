using ECommerce.Core.Application.Repositories.OrderCommentRepositories;
using ECommerce.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Persistence.Repositories.OrderCommentRepositories
{
    public class OrderCommentWriteRepository : WriteRepository<OrderComment>, IOrderCommentWriteRepository
    {
        public OrderCommentWriteRepository(ECommerceDBContext dbContext) : base(dbContext)
        {
        }
    }
}
