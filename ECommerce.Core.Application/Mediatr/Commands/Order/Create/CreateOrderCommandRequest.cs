using System;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.Create
{
	public class CreateOrderCommandRequest : IRequest<CreateOrderCommandResponse>
    {
        public int UserId { get; set; }
        public int AccountId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderType { get; set; } // Default B2C
        public int Status { get; set; } // Received InProgress Pick Pack Ship Delivered
        public int SalesChannel { get; set; }
        public int City { get; set; }
        public int District { get; set; }
        public int Carrier { get; set; }
    }
}

