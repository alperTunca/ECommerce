using System;
using ECommerce.Core.Application.DTOs.Order;
using FluentValidation;

namespace ECommerce.Core.Application.Validators.Order
{
	public class UpdateStatusOrderValidator : AbstractValidator<UpdateStatusOrder>
	{
		public UpdateStatusOrderValidator()
		{
            RuleFor(x => x.AccountId)
                .NotEmpty()
                .NotNull()
                .WithMessage("Hesap bilgisini doldurunuz.");

            RuleFor(x => x.OrderNumber)
                .NotEmpty()
                .NotNull()
                .WithMessage("Sipariş numarasını doldurunuz.");

        }
    }
}

