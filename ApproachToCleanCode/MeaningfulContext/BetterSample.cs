namespace ApproachToCleanCode.MeaningfulContext;

public class BetterSample
{
    /// <summary>
    /// Metotların görevleri contextleri belirli.
    /// Daha kolay maintain edilebilir.
    /// Küçük ve single responsible metotlar
    /// </summary>
    public class GuessStatisticsMessage {
        private string number;
        private string verb;
        private string pluralModifier;
        public string Make(char candidate, int count) {
            CreatePluralDependentMessageParts(count);
            return string.Format(
                "There %s %s %s%s",
                verb, number, candidate, pluralModifier );
        }

        private void CreatePluralDependentMessageParts(int count) {
            if (count == 0) {
                ThereAreNoLetters();
            } else if (count == 1) {
                ThereIsOneLetter();
            } else {
                ThereAreManyLetters(count);
            }
        }

        private void ThereAreManyLetters(int count) {
            number = count.ToString();
            verb = "are";
            pluralModifier = "s";
        }

        private void ThereIsOneLetter() {
            number = "1";
            verb = "is";
            pluralModifier = "";
        }
        
        private void ThereAreNoLetters() {
            number = "no";
            verb = "are";
            pluralModifier = "s";
        }
    }
}