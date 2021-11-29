namespace PackIT.Domain.Policies;

public record PolicyData(TravelDays TravelDays, Enums.Gender Gender, Domain.ValueObjects.Temperature Temperature, Localization Localization);