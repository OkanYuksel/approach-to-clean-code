using ApproachToCleanCode.SOLID.OpenClosedPrinciple;

namespace ApproachToCleanCode.SOLID.DependencyInversion.BetterSample;

public class PrettyFormatter
{
    private PrettyFormatProvider _provider;
    public PrettyFormatter(PrettyFormatProvider provider)
    {
        _provider = provider;
    }

    // Formatlama işlemini yapan metod
    public string Format(string input)
    {
        return _provider.Format(input);
    }
}