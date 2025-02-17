namespace FluentTestamente.Services;

public class UserService
{
	public Guid CurrentUserId {get;set;}

	public UserService()
	{
	}
	public async Task<Guid> FetchCurrentUserIdAsync()
	{
		return CurrentUserId;
	}
}
