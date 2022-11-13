namespace ApproachToCleanCode.GuessingConditionalIntent;

public class BetterSample
{
    private const int MinOldToBuyAlcohol = 16;
    
    public bool IsOldEnoughToBuyAlcohol(int age)
    {
        return age >= MinOldToBuyAlcohol;
    }
}