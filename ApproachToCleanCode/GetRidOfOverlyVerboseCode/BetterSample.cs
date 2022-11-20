namespace ApproachToCleanCode.GetRidOfOverlyVerboseCode;

/// <summary>
/// Aşırı ayrıntılı kod bloğundan kurtulmuş olduk.
/// Daha okunabilir, muhtemelen daha verimli (daha az maliyetli) ve performanslı çalışacak kod.
/// </summary>
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