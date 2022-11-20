namespace ApproachToCleanCode.GetRidOfUnnecessaryAssignments;

public class BadSample
{
    // Sample 1
    // input : currentPermissions = {"files.read", "files.delete"};
    public bool CheckUserCreatePermission(string[] permissions)
    {
        bool hasPermissionsToCreateFile;
        
        if (permissions.Contains("files.create"))
        {
            hasPermissionsToCreateFile = true;
        }
        else
        {
            hasPermissionsToCreateFile = false;
        }

        return hasPermissionsToCreateFile;
    }
    
    // Sample 2
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