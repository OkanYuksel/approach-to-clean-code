namespace ApproachToCleanCode.SOLID.DependencyInversion.BetterSample;

/// <summary>
/// AutoCar sınıfı engine sınıfları ile ilgili bağımlılıklarından kurtuldu. Böylelikle daha kolay geliştirme yapılabilecek ve test yazılabilecek.
/// Autocar sınıfı farklı engine türleriyle çalışabilir hale geldi.
/// Engine türlerinin birbirinden farklı özellikleri, metotları olabilir. Bu metotlar AutoCar sınıfını ilgilendirmez.
/// </summary>
public class BetterSample
{
    public void Process()
    {
        var electricEngine = new ElectricEngine();
        electricEngine.ChargeBattery();
        var electricCar = new AutoCar(electricEngine);
        electricCar.Drive();

        var dieselEngine = new DieselEngine();
        var dieselCar = new AutoCar(dieselEngine);
        dieselCar.Drive();
        
        var gasolineEngine = new GasolineEngine();
        gasolineEngine.AddOilToEngine();
        var gasolineCar = new AutoCar(gasolineEngine);
        gasolineCar.Drive();
    }
}

public class AutoCar : ICar
{
    IEngine _engine;

    public AutoCar(IEngine engine)
    {
        _engine = engine;
    }

    public void Drive()
    {
        string engineStart = _engine.Start();
    }
}

public interface ICar
{
    void Drive();
}

public interface IEngine
{
    string Start();
}

public class DieselEngine : IEngine
{
    public string Start()
    {
        return "Diesel Engine started.";
    }
}

public class ElectricEngine : IEngine
{
    public string Start()
    {
        return "Electric Engine started.";
    }
    
    public string ChargeBattery()
    {
        return "Battery charged.";
    }
}

public class GasolineEngine : IEngine
{
    public string Start()
    {
        return "Gasoline Engine started.";
    }

    public string AddOilToEngine()
    {
        return "Oil added.";
    }
}