namespace ApproachToCleanCode.Clarity;

public class BetterSample
{
    public readonly IUserRepository _userRepository;

    public BetterSample(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<bool> CreateUser(CreateUserInput input)
    {
        var user = input.CreateUser();
        return await _userRepository.CreateAsync(user);
    }
}

public interface ICreateUserInput
{
    User CreateUser();
}

public class CreateUserInput : ICreateUserInput
{
    private const string RegularTag = "regular";
    private const string PremiumTag = "premium";
    private const string TrialTag = "trial";
    private static readonly string[] ValidUserTypes = {RegularTag, PremiumTag, TrialTag};

    public CreateUserInput(string userName, string userType)
    {
        UserName = userName;
        UserType = userType;
    }

    public string UserName { get; private set; }
    public string UserType { get; private set; }

    public User CreateUser()
    {
        return UserType switch
        {
            RegularTag => new User(UserName),
            PremiumTag => new User(UserName, new List<string>() {"PremiumFeature.Read", "PremiumFeature.Create"})
            {
                IsPremium = true
            },
            TrialTag => new User(UserName) {IsOnTrial = true},
            _ => throw new ArgumentOutOfRangeException(
                $"Invalid user type. Must be one of the following {string.Join(" ", ValidUserTypes)}")
        };
    }
}