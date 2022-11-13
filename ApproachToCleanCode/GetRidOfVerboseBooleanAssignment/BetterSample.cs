namespace ApproachToCleanCode.GetRidOfVerboseBooleanAssignment;

public class BetterSample
{
    public bool CheckUserCreatePermission()
    {
        string[] currentPermissions = {"files.read", "files.delete" };

        return currentPermissions.Contains("files.create");
    }
}