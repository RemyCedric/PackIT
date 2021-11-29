
namespace PackIT.Domain.Exceptions
{
    internal class EmptyPackingListItemNameException : PackITException
    {
        public EmptyPackingListItemNameException() : base("packing item name cannot be empty")
        {
        }
    }
}
