namespace ApproachToCleanCode.Clarity;

public class BadSample
{
    public readonly IUserRepository _userRepository;

    public BadSample(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<bool> CreateUser(UserInput input)
    {
        User user;
        switch (input.UserType)
        {
            case "regular":
                user = new User(input.UserName);
                break;
            case "premium":
                user = new User(input.UserName, new List<string>() {"PremiumFeature.Read", "PremiumFeature.Create"});
                user.IsPremium = true;
                break;
            case "trial":
                user = new User(input.UserName);
                user.IsOnTrial = true;
                break;
            default:
                throw new ArgumentOutOfRangeException(
                    $"Invalid user tag.");
        }

        bool result = await _userRepository.CreateAsync(user);
        return result;
    }
}

public class UserInput
{
    public string UserName { get; set; }
    public string UserType { get; set; }
}

public class User
{
    public User(string userName)
    {
        UserName = userName;
    }

    public User(string userName, List<string> permissions)
    {
        UserName = userName;
        Permissions = permissions;
    }

    public string UserName { get; set; }
    public bool IsPremium { get; set; }
    public bool IsOnTrial { get; set; }
    public List<string> Permissions { get; set; }
}

public interface IUserRepository
{
    public Task<bool> CreateAsync(User user);
}