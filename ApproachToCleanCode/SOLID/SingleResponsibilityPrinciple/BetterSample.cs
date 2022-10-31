namespace ApproachToCleanCode.SOLID.SingleResponsibilityPrinciple;

// AddressService class ı ve ChangeAddress metodu sadece adresle ilgileniyor ve sadece adresten sorumlu.
// LoginService in de sorumluluğu belirli. Değişikliklerde birbirlerinden etkilenmiyorlar.

public class LoginService{
    public void Login(string username) {
        //log-in logic 
    }

    public void Logout(string username) {
        //log-out logic
    }
}

public class UserAddressService{   
    public void ChangeAddress(Address address) {
        //logic
    }
}

public class Address {

    private string street;
    private string city;
    private string country;
    //Getter,setter
}