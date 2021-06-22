using System;
using Microsoft.Extensions.DependencyInjection;
using VoidILibrary;
using VoidILibrary.interfaces;

namespace CoolCog
{
    public class CogConfiguration : ICog
    {
        public string CogName { get; set; }
        public string CogDescription { get; set; }
        public float CogVersion { get; set; }

        public CogConfiguration()
        {
            CogName = "CoolCog";
            CogDescription = "A cog for the development team to use when developing Voidwyrm API!";
            CogVersion = 0.1f;
        }

        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<ILogger, Main>();
        }
    }
}