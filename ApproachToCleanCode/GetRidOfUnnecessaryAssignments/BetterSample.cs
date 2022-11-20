namespace ApproachToCleanCode.GetRidOfUnnecessaryAssignments;

public class BetterSample
{
    /// <summary>
    /// Gerekmiyorsa değişkenler oluşturmaktan kaçınmalıyız.
    /// </summary>
    
    //Sample 1
    // input : currentPermissions = {"files.read", "files.delete"};
    public bool CheckUserCreatePermission(string[] permissions)
    {
        return permissions.Contains("files.create");
    }
    
    //Sample 2
    public string GenerateResultMessage(bool operationSucceeded)
    {
        return operationSucceeded
            ? "the operation succeeded"
            : "the operation failed";
    }
}