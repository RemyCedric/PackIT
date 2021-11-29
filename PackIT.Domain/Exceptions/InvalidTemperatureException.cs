namespace PackIT.Domain.Exceptions;
public class InvalidTemperatureException : PackITException
{
    public InvalidTemperatureException(double temperature) : base($"value '{temperature}' is invalid temperature")
    {
    }
}
