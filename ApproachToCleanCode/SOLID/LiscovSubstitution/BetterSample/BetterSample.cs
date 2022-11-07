namespace ApproachToCleanCode.SOLID.LiscovSubstitution.BetterSample;

public class BetterSample
{
    public void Process()
    {
        var car = new Bmw();
        car.EngineStart();
        car.CarAirConditionerStart();
        
        var secondaryCar = new Dacia();
        secondaryCar.EngineStart();
    }
}

public abstract class Car
{
    public virtual string EngineStart()
    {
        return "Engine started.";
    }
}

public interface IAirConditioner
{
    string CarAirConditionerStart();
}

public class Bmw : Car, IAirConditioner
{
    public override string EngineStart()
    {
        return "Bmw's engine started.";
    }

    public string CarAirConditionerStart()
    {
        return "Bmw's air conditioner started.";
    }
}

public class Dacia : Car
{
    public override string EngineStart()
    {
        return "Dacia's engine started.";
    }
}