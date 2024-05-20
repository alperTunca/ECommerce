using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Core.Application.Mediatr.Queries.OrderComment.GetById
{
	public class GetByIdOrderCommentQueryResponse
	{
        public string Comment { get; set; }
        public int AccountId { get; set; }
        public int OrderId { get; set; }
        public int UserId { get; set; }
	}
}

