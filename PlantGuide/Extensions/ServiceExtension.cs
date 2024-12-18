using PlantGuide.DataAccess.Repository.Interfaces;
using PlantGuide.DataAccess.Repository;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.Business.Services;
using Microsoft.OpenApi.Models;

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
        services.AddScoped<IUserRepository, UserRepository>();

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
        services.AddScoped<IUserService, UserService>();

        return services;
    }
    public static IServiceCollection AddSwaggerAuthenticationUi(this IServiceCollection services)
    {
        services.AddSwaggerGen(swagger =>
        {
            //This is to generate the Default UI of Swagger Documentation
            swagger.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "JWT Token Authentication API",
                Description = ".NET 8 Web API"
            });
            // To Enable authorization using Swagger (JWT)
            swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
            });
            swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
            });
        });

        return services;
    }
}
