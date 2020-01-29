using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Dacia.Extensions;
using R5T.Mullingar;


namespace R5T.Rathgormack.Mullingar
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddMullingarHelloWorldMessenger(this IServiceCollection services,
            ServiceAction<IHelloWorldMessageProvider> addHelloWorldMessageProvider)
        {
            services
                .AddSingleton<IHelloWorldMessenger, HelloWorldMessenger>()
                .RunServiceAction(addHelloWorldMessageProvider)
                ;

            return services;
        }
    }
}
