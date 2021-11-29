namespace PackIT.Domain.Exceptions;

public class InvalidTravelDaysException : PackITException
{
    public InvalidTravelDaysException(ushort days) : base($"Value '{days}' is invalid travel days.")
    {
    }
}

