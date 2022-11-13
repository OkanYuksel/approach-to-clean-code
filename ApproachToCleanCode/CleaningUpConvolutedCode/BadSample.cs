namespace ApproachToCleanCode.CleaningUpConvolutedCode;

public class BadSample
{
    public bool ValidatePasswordStrength(string password)
    {
        bool hasValue = !string.IsNullOrEmpty(password);

        if (hasValue)
        {
            bool hasSpecialCharacter = password.Any(character => !char.IsLetterOrDigit(character));

            if (hasSpecialCharacter)
            {
                bool longEnough = password.Length > 10;

                if (longEnough)
                {
                    return true;
                }
                else
                {
                    throw new ArgumentException("Must be at least 18 characters");
                }
            }
            else
            {
                throw new ArgumentException("Must contain at least one special character");
            }
        }
        else
        {
            throw new ArgumentException("Password must have a value", nameof(password));
        }

        return true;
    }
}