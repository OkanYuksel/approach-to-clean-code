namespace ApproachToCleanCode.GetRidOfOverlyVerboseCode;

public class BadSample
{
    public int? FindDuplicate(int[] numbers)
    {
        int? duplicateNumber = null;

        int currentNumber = numbers[0];

        for (var i = 0; i < numbers.Length; i++)
        {
            bool isLastNumber = i + 1 == numbers.Length;
            if (isLastNumber)
            {
                duplicateNumber = currentNumber == numbers[i] ? currentNumber : null;

                break;
            }
            else if (currentNumber == numbers[i + 1])
            {
                duplicateNumber = currentNumber;
                break;
            }

            currentNumber = numbers[i + 1];
        }
        
        return duplicateNumber;
    }
}