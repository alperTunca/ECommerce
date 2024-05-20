using System;
using System.ComponentModel.DataAnnotations;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.OrderComment.Create
{
	public class CreateOrderCommentCommandRequest : IRequest<CreateOrderCommentCommandResponse>
    {
        public int UserId { get; set; }
        public int AccountId { get; set; }
        public int OrderId { get; set; }
        public string Comment { get; set; }
    }
}

