namespace BlazorComponents.Services;

public class ServerService : IService
{
	public string GetSomeText(string input)
	{
		return $"Server Service Response {input}";
	}
}
