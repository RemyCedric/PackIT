namespace PackIT.Application.Exceptions;

public class MissingLocalizationWeatherException : PackITException
{
    public MissingLocalizationWeatherException(Localization localisation)
        : base($"Couldn't fetch weather data for localization '{localisation.Country}'/'{localisation.City}")
    {
    }
}
