namespace ApproachToCleanCode.SOLID.DependencyInversion.BadSample;

public class BadSample
{
    public void Process()
    {
        var car = new Car();
        car.Drive();
    }
}

public class Car
{
    private DieselEngine engine = new DieselEngine();
     
    public void Drive() {    
        string engineStart = engine.start();
    }
}

public class DieselEngine {
    
    public string start() {
        return "DieselEngine started ";
    }
    
}