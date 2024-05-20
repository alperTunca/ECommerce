using System;
using ECommerce.Core.Application.DTOs.Order;
using ECommerce.Core.Application.Mediatr.Commands.Order.UpdateStatus;
using FluentValidation;

namespace ECommerce.Core.Application.Validators.Order
{
	public class UpdateStatusOrderValidator : AbstractValidator<UpdateStatusOrderCommandRequest>
	{
		public UpdateStatusOrderValidator()
        {

            RuleFor(x => x.AccountId)
                .NotEmpty()
                .WithMessage("Hesap bilgisini doldurunuz.")
                .NotNull()
                .WithMessage("Hesap bilgisini doldurunuz.");

            RuleFor(x => x.OrderNumber)
                .NotEmpty()
                .WithMessage("Sipariş numarasını doldurunuz.")
                .NotNull()
                .WithMessage("Sipariş numarasını doldurunuz.");

            RuleFor(x => x.Status)
                .NotEmpty()
                .WithMessage("Sipariş durumu bilgisini doldurunuz.")
                .NotNull()
                .WithMessage("Sipariş durumu bilgisini doldurunuz.");

        }
    }
}

