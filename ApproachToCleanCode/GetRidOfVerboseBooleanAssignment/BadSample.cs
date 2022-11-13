namespace ApproachToCleanCode.GetRidOfVerboseBooleanAssignment;

public class BadSample
{
    public bool CheckUserCreatePermission()
    {
        string[] currentPermissions = {"files.read", "files.delete"};
        
        bool hasPermissionsToCreateFile;
        
        if (currentPermissions.Contains("files.create"))
        {
            hasPermissionsToCreateFile = true;
        }
        else
        {
            hasPermissionsToCreateFile = false;
        }

        return hasPermissionsToCreateFile;
    }
}