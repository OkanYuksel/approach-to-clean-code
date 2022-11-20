namespace ApproachToCleanCode.UsingTheConditionalAccessOperator;

/// <summary>
/// null check için conditional access operatörünü tercih edebiliriz.
/// </summary>
public class BetterSample
{
    private const string SeniorTag = "senior";
    
    public bool CheckEntrancePermission(string title)
    {
        return title?.Contains(SeniorTag) ?? false;
    }

    public bool CheckEntrancePermissionWithInlineFunction(string title) => title?.Contains(SeniorTag) ?? false;
}