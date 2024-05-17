using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Service.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        // Fluent Validation error lar burada duzenlenir
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                var err = context.ModelState
                    .Where(x => x.Value.Errors.Any())
                    .ToDictionary(x => x.Key, e => e.Value.Errors.Select(x => x.ErrorMessage))
                    .ToArray();
                context.Result = new BadRequestObjectResult(err);
                return;
            }

            await next();
        }
    }
}
