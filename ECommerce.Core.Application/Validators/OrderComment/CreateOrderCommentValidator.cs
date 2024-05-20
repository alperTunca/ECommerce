using ECommerce.Core.Application.DTOs.OrderComment;
using ECommerce.Core.Application.Mediatr.Commands.OrderComment.Create;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Application.Validators.OrderComment
{
    public class CreateOrderCommentValidator : AbstractValidator<CreateOrderCommentCommandRequest>
    {
        public CreateOrderCommentValidator() {
            RuleFor(x => x.AccountId)
                .NotEmpty()
                .WithMessage("Hesap bilgisini doldurunuz.")
                .NotNull()
                .WithMessage("Hesap bilgisini doldurunuz.");

            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage("Kullanıcı bilgisini doldurunuz.")
                .NotNull()
                .WithMessage("Kullanıcı bilgisini doldurunuz.");

            RuleFor(x => x.OrderId)
                .NotEmpty()
                .WithMessage("Sipariş ID bilgisini doldurunuz.")
                .NotNull()
                .WithMessage("Sipariş ID bilgisini doldurunuz.");
        }
    }
}
