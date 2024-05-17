using ECommerce.Core.Application.DTOs.OrderComment;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Application.Validators.OrderComment
{
    public class CreateOrderCommentValidator : AbstractValidator<CreateOrderComment>
    {
        public CreateOrderCommentValidator() {
            RuleFor(x => x.AccountId)
                .NotEmpty()
                .NotNull()
                .WithMessage("Hesap bilgisini doldurunuz.");

            RuleFor(x => x.UserId)
                .NotEmpty()
                .NotNull()
                .WithMessage("Kullanıcı bilgisini doldurunuz.");

            RuleFor(x => x.OrderId)
                .NotEmpty()
                .NotNull()
                .WithMessage("Sipariş ID bilgisini doldurunuz.");
        }
    }
}
