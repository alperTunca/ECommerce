using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        // TODO - Test
        // An user can have more than one order
        public List<Order> Orders { get; set; }

        // TODO - Test
        // An ordercomment can belong to an user
        public OrderComment OrderComment { get; set; }
    }
}
