using System;
using System.ComponentModel.DataAnnotations;
using ECommerce.Core.Domain.Enums;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.UpdateStatus
{
	public class UpdateStatusOrderCommandRequest : IRequest<UpdateStatusOrderCommandResponse>
    {
        public int AccountId { get; set; }
        public int OrderNumber { get; set; }
        public OrderStatus Status { get; set; }
    }
}