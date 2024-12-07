using PlantGuide.DataAccess.Repository.Interfaces;
using PlantGuide.DataAccess.Repository;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.Business.Services;

namespace PlantGuide.Extensions;

public static class ServiceExtension
{
    public static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddScoped<IClimateRepository, ClimateRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<IFamilyRepository, FamilyRepository>();
        services.AddScoped<IOriginRepository, OriginRepository>();
        services.AddScoped<IPhotoRepository, PhotoRepository>();
        services.AddScoped<IPlantRepository, PlantRepository>();
        services.AddScoped<ISourceRepository, SourceRepository>();
        services.AddScoped<ITypeSeasonRepository, TypeSeasonRepository>();
        services.AddScoped<ISourcePlantRepository, SourcePlantRepository>();
        services.AddScoped<IFamilyPlantRepository, FamilyPlantRepository>();
        services.AddScoped<IFloweringSeasonPlantRepository, FloweringSeasonPlantRepository>();

        return services;
    }
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services.AddScoped<IClimateService, ClimateService>();
        services.AddScoped<ICountryService, CountryService>();
        services.AddScoped<IFamilyService, FamilyService>();
        services.AddScoped<IOriginService, OriginService>();
        services.AddScoped<IPhotoService, PhotoService>();
        services.AddScoped<IPlantService, PlantService>();
        services.AddScoped<ISourceService, SourceService>();
        services.AddScoped<ITypeSeasonService, TypeSeasonService>();
        services.AddScoped<ISourcePlantService, SourcePlantService>();
        services.AddScoped<IFamilyPlantService,FamilyPlantService>();
        services.AddScoped<IFloweringSeasonPlantService,FloweringSeasonPlantService>();

        return services;
    }
}
