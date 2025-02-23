using Grafika.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Grafika;

public static class DependencyInjection
{
	public static IServiceCollection AddGrafika(this IServiceCollection services)
	{
		services.AddOptions<ConfigurationOptions>()
			.BindConfiguration("Grafika")
			.ValidateDataAnnotations()
			.ValidateOnStart();
		
		return services;
	}
}