namespace PackIT.Domain.Events;

public record PackingItemPacked(PackingList packingList, PackingItem packingItem) : IDomainEvent;
