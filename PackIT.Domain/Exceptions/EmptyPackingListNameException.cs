
namespace PackIT.Domain.Exceptions
{
    internal class EmptyPackingListNameException : PackITException
    {
        public EmptyPackingListNameException() : base("packing list name cannot be empty")
        {
        }
    }
}
