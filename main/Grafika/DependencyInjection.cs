using Grafika.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Grafika;

public static class DependencyInjection
{
	public static IServiceCollection AddGrafika(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddOptions<ConfigurationOptions>()
			.Bind(configuration.GetSection("Grafika"))
			.ValidateDataAnnotations()
			.ValidateOnStart();
		
		return services;
	}
}