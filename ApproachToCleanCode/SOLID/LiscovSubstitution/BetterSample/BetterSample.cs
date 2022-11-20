namespace ApproachToCleanCode.SOLID.LiscovSubstitution.BetterSample;

/// <summary>
/// Her özellik abstract class da bulunmamalı.
/// Sonradan türetilen sınıflara eklenebilecek özellikler interfaceler üzerinden sınıflara eklenmeli ve sınıflar bu özellikleri implemente etmeliler.
/// Böylelikle not implemented exceptionların ya da hatalı durumların önüne geçmiş oluruz.
/// </summary>
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