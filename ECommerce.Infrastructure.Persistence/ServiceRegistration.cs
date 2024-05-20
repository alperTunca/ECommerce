using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.Repositories.OrderCommentRepositories;
using ECommerce.Core.Application.Repositories.OrderRepositories;
using ECommerce.Core.Application.Repositories.UserRepositories;
using ECommerce.Infrastructure.Persistence.Repositories.OrderCommentRepositories;
using ECommerce.Infrastructure.Persistence.Repositories.OrderRepositories;
using ECommerce.Infrastructure.Persistence.Repositories.UserRepositories;
using ECommerce.Infrastructure.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            #region AppSettings.json
            ConfigurationManager configuration = new();
            configuration.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ECommerce.Presentation.API"));
            configuration.AddJsonFile("appsettings.json");
            #endregion

            services.AddDbContext<ECommerceDBContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));


            #region Repositories
            // AddDbCOntext work as AddScoped
            // So repositories can be add using AddScoped (her request için nesne oluşturur ve iş bitince dispose eder)
            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();

            services.AddScoped<IOrderCommentReadRepository, OrderCommentReadRepository>();
            services.AddScoped<IOrderCommentWriteRepository, OrderCommentWriteRepository>();
            #endregion
        }
    }
}
