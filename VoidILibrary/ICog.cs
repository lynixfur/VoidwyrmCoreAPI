using System;
using System.Dynamic;
using Microsoft.Extensions.DependencyInjection;

namespace VoidILibrary
{
    public interface ICog
    {
        public string CogName { get; set; }
        public string CogDescription { get; set; }

        public float CogVersion { get; set; }

        void Configure(IServiceCollection services);
        void InitializeEvents(IEventManager eventManager);
    }
}