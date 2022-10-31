namespace ApproachToCleanCode.SOLID.InterfaceSegregation.BadSample;

public interface IPrettyFormatValidator
{
    string Schema { get; set; }
    bool IsValid(string input);
}

public class JsonValidator:IPrettyFormatValidator
{
    public string Schema { get; set; }
    public bool IsValid(string input)
    {
        // logic
        return true;
    }
}

public class HtmlValidator:IPrettyFormatValidator
{
    public string Schema { get; set; }
    public bool IsValid(string input)
    {
        // logic
        return true;
    }
}

public class XmlValidator:IPrettyFormatValidator
{
    public string Schema { get; set; }
    public bool IsValid(string input)
    {
        // logic
        return true;
    }
}

public class XmlSchemaValidator:IPrettyFormatValidator
{
    public string Schema { get; set; }

    public bool IsValid(string input)
    {
        // logic
        return true;
    }
}