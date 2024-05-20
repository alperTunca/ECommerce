using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Core.Application.Mediatr.Queries.Order.GetById
{
	public class GetByIdOrderQueryResponse
    {
        public int AccountId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderType { get; set; } 
        public int Status { get; set; } 
        public int SalesChannel { get; set; }
        public int City { get; set; }
        public int District { get; set; }
        public int Carrier { get; set; } 
        public int UserId { get; set; }
    }
}

