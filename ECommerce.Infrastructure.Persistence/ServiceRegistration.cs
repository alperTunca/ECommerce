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

            #endregion
        }
    }
}
