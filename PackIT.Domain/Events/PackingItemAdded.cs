namespace PackIT.Domain.Events;

public record PackingItemAdded(PackingList packingList, PackingItem packingItem) : IDomainEvent;