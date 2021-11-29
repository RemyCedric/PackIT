namespace PackIT.Domain.Policies.Universal
{
    public class BasicPolicy : IPackingItemPolicy
    {
        public bool IsApplicable(PolicyData _)
            => true;
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>{
                new("pants", 5),
                new("socks", 10),
                new("gloves", 1)
            };

    }
}