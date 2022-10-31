namespace ApproachToCleanCode.SOLID.SingleResponsibilityPrinciple;

public class User {
    private long id;
    private string name;
    private string street;
    private string city;
    private string username;
   
    //Getters, setters
   
    public void ChangeAddress(string street, string city) {
        //logic
    }
   
    public void Login(string username) {
        //logic
    }
   
    public void Logout(string username) {
        //logic
    }
}