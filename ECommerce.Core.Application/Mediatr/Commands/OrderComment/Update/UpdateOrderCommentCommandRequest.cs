using MediatR;
using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Application.Mediatr.Commands.OrderComment.Update
{
	public class UpdateOrderCommentCommandRequest : IRequest<UpdateOrderCommentCommandResponse>
	{
		public int Id { get; set; }
        public int AccountId { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public string Comment { get; set; }
	}
}

