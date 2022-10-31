namespace ApproachToCleanCode.SOLID.LiscovSubstitution;

public class BadSample
{
    public void Process()
    {
        Car car = new Bmw();
        car.EngineStart();
        car.CarAirConditioner();
        
        Car secondaryCar = new Dacia();
        secondaryCar.EngineStart();
        secondaryCar.CarAirConditioner();
    }
}

public abstract class Car
{
    public virtual string EngineStart()
    {
        return "Engine started.";
    }

    public virtual string CarAirConditioner()
    {
        return "Air conditioner started.";
    }
}

public class Bmw : Car
{
    public override string EngineStart()
    {
        return "Bmw's engine started.";
    }

    public override string CarAirConditioner()
    {
        return "Bmw's air conditioner started.";
    }
}

public class Dacia : Car
{
    public override string EngineStart()
    {
        return "Dacia's started.";
    }
    
    public override string CarAirConditioner()
    {
        throw new NotImplementedException();
    }
}