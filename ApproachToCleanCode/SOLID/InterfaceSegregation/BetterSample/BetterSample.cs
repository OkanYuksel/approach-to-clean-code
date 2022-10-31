namespace ApproachToCleanCode.SOLID.InterfaceSegregation.BetterSample;

public interface IPrettyFormatValidator
{
    bool IsValid(string input);
}
public interface IPrettyFormatSchemaValidator:IPrettyFormatValidator
{
    string Schema { get; set; }
}

public class JsonValidator:IPrettyFormatValidator
{
    public bool IsValid(string input)
    {
        // logic
        return true;
    }
}
public class HtmlValidator:IPrettyFormatValidator
{
    public bool IsValid(string input)
    {
        // logic
        return true;
    }
}

public class XmlValidator:IPrettyFormatValidator
{
    public bool IsValid(string input)
    {
        // logic
        return true;
    }
}

public class XmlSchemaValidator:IPrettyFormatSchemaValidator
{
    public string Schema { get; set; }

    public bool IsValid(string input)
    {
        // logic
        return true;
    }
}