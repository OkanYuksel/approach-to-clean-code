namespace ApproachToCleanCode.MeaningfulContext;

public class BadSample
{
    private string GetGuessStatistics(char candidate, int count) {
        string number;
        string verb;
        string pluralModifier;
        if (count == 0) {
            number = "no";
            verb = "are";
            pluralModifier = "s";
        } else if (count == 1) {
            number = "1";
            verb = "is";
            pluralModifier = "";
        } else {
            number = count.ToString();
            verb = "are";
            pluralModifier = "s";
        }
        return string.Format($"There %s %s %s%s", verb, number, candidate, pluralModifier);
    }
}