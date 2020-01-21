using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace EventBus.Base.Standard.Configuration
{
    public static class Handling
    {
        public static IServiceCollection AddEventBusHandling<T>(this IServiceCollection services, IEnumerable<T> handlers)
        {
            foreach (var handler in handlers)
            {
                services.AddTransient(handler.GetType());
            }

            return services;
        }
    }
}
