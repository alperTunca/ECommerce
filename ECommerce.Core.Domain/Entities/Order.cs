using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int AccountId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderType { get; set; } = "B2C"; // Default B2C
        public int Status { get; set; } // Received InProgress Pick Pack Ship Delivered
        public int SalesChannel { get; set; }
        public int City { get; set; }
        public int District { get; set; }
        public int Carrier { get; set; } // Carrier Company Code
        //public int UserId { get; set; }

        // TODO - Test
        // An order can belong to an user 
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        // TODO - Test
        // An order can have more than one ordercomment
        public List<OrderComment> OrderComments { get; set; }
    }
}
