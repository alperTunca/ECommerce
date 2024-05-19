using System;
using ECommerce.Core.Application.DTOs.User;

namespace ECommerce.Core.Application.Mediatr.Queries.User.GetAll
{
	public class GetAllUserQueryResponse
    {
        public List<SingleUser> Users { get; set; }
    }
}

