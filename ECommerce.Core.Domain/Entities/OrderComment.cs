using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Domain.Entities
{
    public class OrderComment : BaseEntity
    {
        //public int OrderId { get; set; }
        //public int UserId { get; set; }
        public string Comment { get; set; }

        // TODO - Test
        // An ordercomment can belong to an order 
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        // TODO - Test
        // An ordercomment can belong to an user 
        [ForeignKey("User")]
        public int UserId { get; set; }

        [InverseProperty("OrderComment")]
        public User User { get; set; }
    }
}
