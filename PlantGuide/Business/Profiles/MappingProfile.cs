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
        CreateMap<CreateFamilyDTO, Family>();
        CreateMap<CreateOriginDTO, Origin>();
        CreateMap<CreateSourceDTO, Source>();
        CreateMap<CreatePlantDTO, Plant>();
        CreateMap<CreateTypeSeasonDTO,TypeSeason>();
    }
}
