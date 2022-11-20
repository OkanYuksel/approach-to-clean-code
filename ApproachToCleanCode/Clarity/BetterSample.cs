namespace ApproachToCleanCode.Clarity;

/// <summary>
/// User create etme işleminde kullanılan metotlara netlik kazandırmış olduk. Hepsinin görevi belli.
/// Değişkenler tekrar kullanım için hazır hale geldi.
/// Key, tag gibi kavramlar için static class lar oluşturduk. Hardcoded değiller artık. Searchable oldular.
/// </summary>
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

public static class FeatureKeys
{
    public const string PremiumFeatureRead = "PremiumFeature.Read";
    public const string PremiumFeatureCreate = "PremiumFeature.Create";
}

public static class UserTags
{
    public const string Regular = "regular";
    public const string Premium = "premium";
    public const string Trial = "trial";
}

public class CreateUserInput : ICreateUserInput
{
    public CreateUserInput(string userName, string userType)
    {
        UserName = userName;
        UserType = userType;
    }

    private string UserName { get; set; }
    private string UserType { get; set; }

    public User CreateUser()
    {
        return UserType switch
        {
            UserTags.Regular => new User(UserName),
            UserTags.Premium => new User(UserName, 
                new List<string>() {FeatureKeys.PremiumFeatureRead, FeatureKeys.PremiumFeatureCreate})
            {
                IsPremium = true
            },
            UserTags.Trial => new User(UserName) {IsOnTrial = true},
            _ => throw new ArgumentOutOfRangeException(
                $"Invalid user tag.")
        };
    }
}