namespace ApproachToCleanCode.DontHaveSideEffects.BadSample;

public class UserValidator
{
    private Cryptographer _cryptographer;

    public UserValidator()
    {
        _cryptographer = new Cryptographer();
    }

    public bool CheckPassword(string userName, string password)
    {
        User user = UserGateway.FindByName(userName);

        if (user != null)
        {
            string codePhrase = user.GetPhraseEncodedByPassword();
            string phrase = _cryptographer.Decrypt(codePhrase, password);
            if ("Valid Password".Equals(phrase))
            {
                Session.Initialize();
                return true;
            }
        }
        return false;
    }
}

public static class Session
{
    public static void Initialize()
    {
        
    }
}

public class User
{
    public string GetPhraseEncodedByPassword()
    {
        return string.Empty;
    }
}

public static class UserGateway
{
    public static User FindByName(string userName)
    {
        return new User();
    }
}

public class Cryptographer
{
    public string Decrypt(string codedPhrase, string password)
    {
        return "Valid Password";
    }
}