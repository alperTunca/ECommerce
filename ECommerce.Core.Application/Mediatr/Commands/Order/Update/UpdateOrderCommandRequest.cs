using System;
using ECommerce.Core.Domain.Enums;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.Update
{
	public class UpdateOrderCommandRequest : IRequest<UpdateOrderCommandResponse>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AccountId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderType OrderType { get; set; }
        public OrderStatus Status { get; set; }
        public string SalesChannel { get; set; }
        public int City { get; set; }
        public int District { get; set; }
        public int Carrier { get; set; }
    }
}

