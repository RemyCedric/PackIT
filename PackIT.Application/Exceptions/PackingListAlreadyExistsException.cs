namespace PackIT.Application.Exceptions;

public class PackingListAlreadyExistsException : PackITException
{
    public PackingListAlreadyExistsException(string name) : base($"Packing list with name '{name}' already exists")
    {
    }
}
