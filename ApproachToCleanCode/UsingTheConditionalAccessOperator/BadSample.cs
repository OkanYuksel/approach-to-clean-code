namespace ApproachToCleanCode.UsingTheConditionalAccessOperator;

public class BadSample
{
    public bool CheckEntrancePermission(string title)
    {
        bool isAllowedEntrance = false;

        if (!string.IsNullOrEmpty(title) && title.Contains("senior"))
        {
            isAllowedEntrance = true;
        }

        return isAllowedEntrance;
    }
}