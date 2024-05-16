using ECommerce.Core.Application.Repositories.UserRepositories;
using ECommerce.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Persistence.Repositories.UserRepositories
{
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        public UserReadRepository(ECommerceDBContext dbContext) : base(dbContext)
        {
        }
    }
}
