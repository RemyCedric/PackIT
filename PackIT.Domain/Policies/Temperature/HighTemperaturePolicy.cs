namespace PackIT.Domain.Policies.Temperature;
internal sealed class HighTemperaturePolicy : IPackingItemPolicy
{
    public bool IsApplicable(PolicyData data)
        => data.Temperature > 25D;

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
        => new List<PackingItem>{
            new("hat", 1),
            new("sunglasses", 1)
    };
}