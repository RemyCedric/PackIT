
namespace PackIT.Domain.Exceptions
{
    internal class PackingItemAlreadyExistException : PackITException
    {
        public PackingItemAlreadyExistException(string listName, string itemName) :
            base($"Packing list '{listName}' already defined item '{itemName}'")
        {
        }
    }
}
