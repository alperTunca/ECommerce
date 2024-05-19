using System;
using System.ComponentModel.DataAnnotations;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.UpdateStatus
{
	public class UpdateStatusOrderCommandRequest : IRequest<UpdateStatusOrderCommandResponse>
	{
        public int AccountId { get; set; }
        public int OrderNumber { get; set; }
    }
}