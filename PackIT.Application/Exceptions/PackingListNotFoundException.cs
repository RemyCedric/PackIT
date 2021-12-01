namespace PackIT.Application.Exceptions;
public class PackingListNotFoundException : PackITException
{
    public PackingListNotFoundException(Guid packingListId) : base($"Packing list with id '{packingListId}' is not found.")
    {
    }
}
