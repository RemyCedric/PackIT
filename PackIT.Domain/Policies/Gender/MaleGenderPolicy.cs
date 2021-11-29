namespace PackIT.Domain.Policies.Gender;

internal sealed class MaleGenderPolicy : IPackingItemPolicy
{
    public bool IsApplicable(PolicyData data)
        => data.Gender is Enums.Gender.Male;

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
        => new List<PackingItem>{
            new("laptop", 1),
            new("beer", 10),
            new("book", 2),
    };


}