using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Application.DTOs.Order
{
    public class UpdateOrder
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AccountId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderType { get; set; }
        public int Status { get; set; } 
        public int SalesChannel { get; set; }
        public int City { get; set; }
        public int District { get; set; }
        public int Carrier { get; set; }
    }
}
