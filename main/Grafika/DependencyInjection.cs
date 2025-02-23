using Grafika.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Grafika;

public static class DependencyInjection
{
	public static IServiceCollection AddGrafika(this IServiceCollection services, 
		Action<ConfigurationOptions> configureOptions)
	{
		var options = new ConfigurationOptions();
		configureOptions(options);
		return services;
	}
}