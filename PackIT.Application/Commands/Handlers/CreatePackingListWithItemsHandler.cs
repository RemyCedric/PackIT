namespace PackIT.Application.Commands.Handlers;

public class CreatePackingListWithItemsHandler : ICommandHandler<CreatePackingListWithItems>
{
    private readonly IPackingListFactory _factory;
    private readonly IPackingListReadService _readService;
    private readonly IPackingListRepository _repository;
    private readonly IWeatherService _weatherService;

    public CreatePackingListWithItemsHandler(IPackingListFactory factory, IPackingListReadService readService, IPackingListRepository repository, IWeatherService weatherService)
    {
        _factory = factory;
        _readService = readService;
        _repository = repository;
        _weatherService = weatherService;
    }

    public async Task HandleAsync(CreatePackingListWithItems command)
    {
        var (id, name, days, gender, localizationWriteModel) = command;

        if (await _readService.ExistByNameAsync(name))
        {
            throw new PackingListAlreadyExistsException(name);
        }

        var localization = new Localization(localizationWriteModel.City, localizationWriteModel.Country);

        var weather = await _weatherService.GetWeatherAsync(localization);

        if (weather is null)
        {
            throw new MissingLocalizationWeatherException(localization);
        }


        var packingList = _factory.CreateWithDefaultItems(id, name, days, gender, weather.Temperature, localization);

        await _repository.AddAsync(packingList);

    }
}
