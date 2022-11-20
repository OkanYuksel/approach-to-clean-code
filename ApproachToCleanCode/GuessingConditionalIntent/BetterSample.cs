namespace ApproachToCleanCode.GuessingConditionalIntent;

public class BetterSample
{
    private const int MinOldToBuyAlcohol = 16;
    
    /// <summary>
    /// If condition yerine bu kullanım daha sade.
    /// </summary>
    public bool IsOldEnoughToBuyAlcohol(int age)
    {
        return age >= MinOldToBuyAlcohol;
    }
}