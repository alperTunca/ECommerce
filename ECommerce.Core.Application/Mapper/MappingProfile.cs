using System;
using AutoMapper;
using ECommerce.Core.Application.DTOs.Order;
using ECommerce.Core.Application.DTOs.OrderComment;
using ECommerce.Core.Application.DTOs.User;
using ECommerce.Core.Application.Mediatr.Commands.Order.Create;
using ECommerce.Core.Application.Mediatr.Commands.User.Create;
using ECommerce.Core.Domain.Entities;

namespace ECommerce.Core.Application.Mapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			// TODO - Mapper nasıl çalışır ?
			CreateMap<User, SingleUser>();
			CreateMap<CreateUserCommandRequest, User>();


			CreateMap<CreateOrderComment, OrderComment>();
			CreateMap<List<OrderComment>, ListOrderComment>();
			CreateMap<OrderComment, SingleOrderComment>();

			CreateMap<CreateOrderCommandRequest,CreateOrder>();
		}
	}
}

