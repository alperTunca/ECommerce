﻿using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection collection)
        {
            collection.AddMediatR(typeof(ServiceRegistration));
            collection.AddAutoMapper(typeof(ServiceRegistration));
        }
    }
}

