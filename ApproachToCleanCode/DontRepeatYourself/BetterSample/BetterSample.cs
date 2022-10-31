namespace ApproachToCleanCode.DontRepeatYourself.BetterSample;

// Modüler, tekrar tekrar kullanılabilir metotlar yazmalıyız. 
// Kod tekrarına düşersek sorun kaçınılmaz olur.
public class BetterSample
{
    private TemperatureDomainService _temperatureDomainService;

    public BetterSample()
    {
        _temperatureDomainService = new TemperatureDomainService();
    }
    
    public int FindHighestTemperatureByCelciusInCities(City firstCity, City secondCity)
    {
        var firstTemperatureByCelcius = _temperatureDomainService.GetCityTemperatureByCelcius(firstCity.CityCode);

        var secondTemperatureByCelcius = _temperatureDomainService.GetCityTemperatureByCelcius(secondCity.CityCode);

        return firstTemperatureByCelcius >= secondTemperatureByCelcius
            ? firstTemperatureByCelcius
            : secondTemperatureByCelcius;
    }
}

public class TemperatureDomainService
{
    public int GetCityTemperatureByFahrenheit(int cityCode)
    {
        Random random = new Random();
        return random.Next(40, 50);
    }
    
    public int GetCityTemperatureByCelcius(int cityCode)
    {
        var cityTemperatureByFahrenheit = GetCityTemperatureByFahrenheit(cityCode);
        return ConvertFahrenheitTemperatureToCelcius(cityTemperatureByFahrenheit);
    }

    public int ConvertFahrenheitTemperatureToCelcius(int fahrenheitTemperature)
    {
        return (fahrenheitTemperature - 32) * 5 / 9;
    }
}

public class City
{
    public int CityCode { get; set; }
}
