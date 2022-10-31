namespace ApproachToCleanCode.SOLID.OpenClosedPrinciple;

public class PrettyFormatter
{
    // Format tipleri
    public enum FormatTypes
    {
        Json,
        Html
    }

    // Formatlama işlemini yapacak olan nesneler
    private JsonFormatter _jsonFormatter = new JsonFormatter();
    private HtmlFormatter _htmlFormatter = new HtmlFormatter();

    // Formatlama işlemini yapan metod
    public string Format(FormatTypes inputType, string input)
    {
        switch (inputType)
        {
            case FormatTypes.Json:
                return _jsonFormatter.Format(input);
            case FormatTypes.Html:
                return _htmlFormatter.Format(input);
            default:
                throw new Exception("Desteklenmeyen format tipi!");
        }
    }
}