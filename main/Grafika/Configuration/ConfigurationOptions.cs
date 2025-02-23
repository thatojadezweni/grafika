namespace Grafika.Configuration;

public sealed class ConfigurationOptions
{
	internal ConfigurationOptions()
	{
		
	}
	
	public string Uri { get; set; }
	
	public string Username { get; set; }
	
	public string Password { get; set; }
}