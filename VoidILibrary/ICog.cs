using System;

using Microsoft.Extensions.DependencyInjection;

namespace VoidILibrary
{
    public interface ICog
    {
        void Configure(IServiceCollection services);
    }
}