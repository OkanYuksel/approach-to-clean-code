using ApproachToCleanCode.DontHaveSideEffects.BadSample;

namespace ApproachToCleanCode.DontHaveSideEffects.BetterSample;

public class UserValidator
{
    /* CheckPassword metodu içerisindeki Session.Initialize() metodu kaldırılmalı
     ya da CheckPassword metodunun adı CheckPasswordAndInitializeSession olarak değiştirilmeli.*/
    private Cryptographer _cryptographer;

    public UserValidator()
    {
        _cryptographer = new Cryptographer();
    }

    public bool CheckPasswordAndInitializeSession(string userName, string password)
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
