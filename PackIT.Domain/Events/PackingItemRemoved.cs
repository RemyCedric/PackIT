namespace PackIT.Domain.Events;

public record PackingItemRemoved(PackingList packingList, PackingItem packingItem) : IDomainEvent;