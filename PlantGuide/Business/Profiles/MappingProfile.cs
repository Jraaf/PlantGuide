using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;

namespace PlantGuide.Business.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateClimateDTO, Climate>();
        CreateMap<CreateCountryDTO, Country>();
        CreateMap<CreatePhotoDTO, Photo>();
        CreateMap<CreateFamilyDTO, Family>();
        CreateMap<CreateOriginDTO, Origin>();
        CreateMap<CreatePlantDTO, Plant>();
        CreateMap<CreateSourceDTO, Source>();
        CreateMap<CreateTypeSeasonDTO,TypeSeason>();
    }
}
