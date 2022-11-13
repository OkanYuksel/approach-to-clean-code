namespace ApproachToCleanCode.GuessingConditionalIntent;

public class BadSample
{
    public bool IsOldEnoughToBuyAlcohol(int age)
    {
        if (age >= 16)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}