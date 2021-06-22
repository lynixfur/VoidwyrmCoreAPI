using System;
using Microsoft.Extensions.DependencyInjection;
using VoidILibrary;
using VoidILibrary.interfaces;

namespace CoolCog
{
    public class CogConfiguration : ICog
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<ILogger, Main>();
        }
    }
}