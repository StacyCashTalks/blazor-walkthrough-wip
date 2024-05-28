namespace BlazorComponents.Services;

public class ClientService : IService
{
	public string GetSomeText(string input)
	{
		return $"Client Service Response {input}";
	}
}
