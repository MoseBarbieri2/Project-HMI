using Microsoft.Extensions.DependencyInjection;
using Template.Services.Shared;
using Template_UMI.web1.SignalR;

namespace Template_UMI.web1
{
    public class Container
    {
        public static void RegisterTypes(IServiceCollection container)
        {
            // Registration of all the database services you have
            container.AddScoped<SharedService>();

            // Registration of SignalR events
            container.AddScoped<IPublishDomainEvents, SignalrPublishDomainEvents>();
        }
    }
}
