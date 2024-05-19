using System;
namespace ECommerce.Core.Application.DTOs.OrderComment
{
	public class SingleOrderComment
    {
        public int AccountId { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public string Comment { get; set; }
    }
}

