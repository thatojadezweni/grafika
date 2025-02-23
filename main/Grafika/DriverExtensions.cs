using Neo4j.Driver;

namespace Grafika;

public static class DriverExtensions
{
	/// <summary>
	/// Executes the cypher query that selects a single value.
	/// </summary>
	/// <param name="driver">The <see cref="IDriver"/> instance.</param>
	/// <param name="cypher">The cypher query.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The query result returned as <see cref="object"/>.</returns>
	public static Task<object> ExecuteScalarAsync(this IDriver driver, string cypher, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}
	
	/// <summary>
	/// Executes the cypher query that selects a single value.
	/// </summary>
	/// <param name="driver">The <see cref="IDriver"/> instance.</param>
	/// <param name="cypher">The cypher query.</param>
	/// <returns>The query result returned as <see cref="object"/>.</returns>
	public static object ExecuteScalar(this IDriver driver, string cypher)
	{
		throw new NotImplementedException();
	}
}