namespace ApproachToCleanCode.CleaningUpConvolutedCode;

// İç içe iflerin olduğu kod bloğundan kurtulmuş olduk.
public class BetterSample
{
    private const int MaxPasswordLength = 10;
    public bool ValidatePasswordStrengthBetter(string password)
    {
        if (string.IsNullOrEmpty(password))
            throw new ArgumentException("Cannot be null or empty");
        if (password.Any(char.IsLetterOrDigit))
            throw new ArgumentException("Must contain at least one special character");
        if (password.Length > MaxPasswordLength)
            throw new ArgumentException("Must be at least 10 characters");

        return true;
    }
}