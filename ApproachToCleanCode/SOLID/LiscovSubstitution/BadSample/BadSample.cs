namespace ApproachToCleanCode.SOLID.LiscovSubstitution;

public class BadSample
{
    public void Process()
    {
        Car car = new Bmw();
        car.EngineStart();
        car.CarAirConditionerStart();
        
        Car secondaryCar = new Dacia();
        secondaryCar.EngineStart();
        secondaryCar.CarAirConditionerStart();
    }
}

public abstract class Car
{
    public virtual string EngineStart()
    {
        return "Engine started.";
    }

    public virtual string CarAirConditionerStart()
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

    public override string CarAirConditionerStart()
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
    
    public override string CarAirConditionerStart()
    {
        throw new NotImplementedException();
    }
}