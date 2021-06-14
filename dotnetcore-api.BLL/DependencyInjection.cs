using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnet5Api.BLL.Interfaces.Services;
using dotnet5Api.BLL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace dotnet5Api.BLL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessLogicModule(this IServiceCollection services)
        {
            services.AddTransient<IHashTableService, HashTableService>();
            return services;
        }
    }
}
