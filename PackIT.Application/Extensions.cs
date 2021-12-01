﻿namespace PackIT.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddCommands();
        services.AddQueries();
        services.AddSingleton<IPackingListFactory, PackingListFactory>();

        services.Scan(b => b.FromAssemblies(typeof(IPackingItemPolicy).Assembly)
        .AddClasses(c => c.AssignableTo<IPackingItemPolicy>())
        .AsImplementedInterfaces()
        .WithSingletonLifetime());

        return services;
    }
}
