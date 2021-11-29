namespace PackIT.Domain.Exceptions;

public class PackingItemNotFoundException : PackITException
{
    public PackingItemNotFoundException(string itemName)
        : base($"Packing item '{itemName}' was not found")
    {
    }
}