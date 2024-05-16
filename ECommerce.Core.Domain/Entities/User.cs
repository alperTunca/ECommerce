using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Can be store with hash and salt in DB. 

        // An user can have more than one order
        public List<Order> Orders { get; set; }
    }
}
