using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class SourcePlantService : Crud<SourcePlant, CreateSourcePlantDTO>, ISourcePlantService
{
    public SourcePlantService(IMapper mapper, ISourcePlantRepository repo)
        : base(mapper, repo)
    {

    }
}
