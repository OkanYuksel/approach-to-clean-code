namespace ApproachToCleanCode.GetRidOfVerboseValueAssignment;

public class BetterSample
{
    public string GenerateResultMessage(bool operationSucceeded)
    {
        return operationSucceeded
            ? "the operation succeeded"
            : "the operation failed";
    }
}