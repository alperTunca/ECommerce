using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Application.DTOs.User
{
    public class SingleUser
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } 

        // TODO
        //public List<Order> Orders { get; set; }
        //public OrderComment OrderComment { get; set; }
    }
}
