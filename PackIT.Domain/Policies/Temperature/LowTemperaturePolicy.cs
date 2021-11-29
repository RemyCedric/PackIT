namespace PackIT.Domain.Policies.Temperature;
internal sealed class LowTemperaturePolicy : IPackingItemPolicy
{
    public bool IsApplicable(PolicyData data)
        => data.Temperature < 10D;

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
        => new List<PackingItem>{
            new("winter hat", 1),
            new("scarf", 1),
            new("gloves", 1)
    };
}