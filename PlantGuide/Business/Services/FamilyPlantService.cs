using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class FamilyPlantService : Crud<FamilyPlant, CreateFamilyPlantDTO>, IFamilyPlantService
{
    public FamilyPlantService(IMapper mapper, IFamilyPlantRepository repo)
        : base(mapper, repo)
    {

    }
}
