namespace ApproachToCleanCode.GetRidOfOverlyVerboseCode;

// Aşırı ayrıntılı kod bloğundan kurtulmuş olduk.
public class BetterSample
{
    public int? FindDuplicateBetter(IEnumerable<int> numbers)
    {
        int? duplicateNumber = null;
        
        var set = new HashSet<int>();

        foreach (var number in numbers)
        {
            if (set.Contains(number))
            {
                duplicateNumber = number;
                break;
            }
            set.Add(number);
        }
        return duplicateNumber;
    }
}