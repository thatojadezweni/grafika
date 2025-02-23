using Microsoft.Extensions.DependencyInjection;

namespace Grafika;

public static class DependencyInjection
{
	public static IServiceCollection AddGrafika(this IServiceCollection services)
	{
		return services;
	}
}