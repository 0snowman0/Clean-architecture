using Application.Contracts.Persistence.Generic;
using Application.Contracts.Persistence.Tables;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.AddDbContext<Context_En>(options =>
            {
                options.UseSqlServer(configuration
                    .GetConnectionString("DefaultConnection"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            
            services.AddScoped<ITestTable, TestTable_Rep>();

            return services;
        }
    }
}
