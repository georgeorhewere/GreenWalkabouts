using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Walkabouts.Services.Implementations;
using Walkabouts.Services.Interfaces;

namespace Walkabouts.API
{
    public static class WalkaboutServices
    {
        public static IServiceCollection AddWalkaboutServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            return services;
        }
    }
}
