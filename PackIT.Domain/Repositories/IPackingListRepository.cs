namespace PackIT.Domain.Repositories;
public interface IPackingListRepository
{
    Task<PackingList> GetAsync(PackingListId id);
    Task<PackingList> AddAsync(PackingList list);
    Task<PackingList> UpdateAsync(PackingList list);
    Task<PackingList> DeleteAsync(PackingList list);
}
