using HelixComponents.Feature.Recommended.Mediators;
using HelixComponents.Feature.Recommended.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace HelixComponents.Feature.Recommended.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IRecommendedMediator, RecommendedMediator>();
            serviceCollection.AddTransient<IRecommendedService, RecommendedService>();
        }
    }
}
