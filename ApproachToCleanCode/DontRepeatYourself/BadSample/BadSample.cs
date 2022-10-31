namespace ApproachToCleanCode.DontRepeatYourself.BadSample;

public class BadSample
{
    public int FindHighestTemperatureByCelciusInCities(City firstCity, City secondCity)
    {
        var firstTemperatureByFahrenheit = GetCityTemperatureByFahrenheit(firstCity.CityCode);
        var firstTemperatureByCelcius = (firstTemperatureByFahrenheit - 32) * 5 / 9;

        var secondTemperatureByFahrenheit = GetCityTemperatureByFahrenheit(secondCity.CityCode);
        var secondTemperatureByCelcius = (secondTemperatureByFahrenheit - 32) * 5 / 9;

        return firstTemperatureByCelcius >= secondTemperatureByCelcius
            ? firstTemperatureByCelcius
            : secondTemperatureByCelcius;
    }

    public int GetCityTemperatureByFahrenheit(int cityCode)
    {
        Random random = new Random();
        return random.Next(40, 50);
    }
}

public class City
{
    public int CityCode { get; set; }
}