using CQRS_Wrokshop.Application.Users;
using CQRS_Wrokshop.Domain.Respositories;
using CQRS_Wrokshop.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Wrokshop.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            //services.AddAutoMapper(typeof(CategoryMappingProfile));
            services.AddAutoMapper(typeof(UserMappingProfile));
           // services.AddAutoMapper(typeof(OrderMappingProfile));

            services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IOrderService, OrderService>();   
            return services;
        }
    }
}
