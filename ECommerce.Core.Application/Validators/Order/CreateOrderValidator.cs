using ECommerce.Core.Application.Mediatr.Commands.Order.Create;
using ECommerce.Core.Application.Mediatr.Commands.Order.UpdateStatus;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Application.Validators.Order
{
    public class CreateOrderValidator : AbstractValidator<CreateOrderCommandRequest>
    {
        public CreateOrderValidator()
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
