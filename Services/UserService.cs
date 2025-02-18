namespace FluentTestamente.Services;

public class UserService
{
	public Guid CurrentUserId {get;set;}

	public UserService()
	{
	}
	public async Task<Guid> FetchCurrentUserIdAsync()
	{
		if (CurrentUserId == Guid.Empty)
		{
			CurrentUserId = Guid.NewGuid();
		}
		return CurrentUserId;
	}
}
