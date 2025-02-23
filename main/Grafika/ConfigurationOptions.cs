using System.ComponentModel.DataAnnotations;

namespace Grafika.Configuration;

internal sealed class ConfigurationOptions
{
	[Required(ErrorMessage = "Uri is required.")]
	[Url(ErrorMessage = "Uri is in an invalid format.")]
	public string Uri { get; init; }
	
	[Required(ErrorMessage = "Username is required.")]
	public string Username { get; init; }
	
	[Required(ErrorMessage = "Password is required.")]
	public string Password { get; init; }
}