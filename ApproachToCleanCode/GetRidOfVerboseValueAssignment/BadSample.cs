namespace ApproachToCleanCode.GetRidOfVerboseValueAssignment;

public class BadSample
{
    public string GenerateResultMessage(bool operationSucceeded)
    {
        var message = string.Empty;

        if (operationSucceeded)
        {
            message = "the operation succeeded";
        }
        else
        {
            message = "the operation failed";
        }

        return message;
    }
}