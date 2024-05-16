using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int AccountId { get; set; }
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderType { get; set; } // Default B2C
        public int Status { get; set; } // Received InProgress Pick Pack Ship Delivered
        public int SalesChannel { get; set; }
        public int City { get; set; }
        public int District { get; set; }
        public int Carrier { get; set; } // Carrier Company Code
        public int UserId { get; set; }
    }
}
