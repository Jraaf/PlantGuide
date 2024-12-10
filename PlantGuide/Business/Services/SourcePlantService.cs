using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class SourcePlantService : Crud<SourcePlant, CreateSourcePlantDTO>, ISourcePlantService
{
    private readonly IMapper mapper;
    private readonly ISourcePlantRepository repo;

    public SourcePlantService(IMapper mapper, ISourcePlantRepository repo)
        : base(mapper, repo)
    {
        this.mapper = mapper;
        this.repo = repo;
    }

    public async Task<List<SourcePlant>> GetByPlantId(int plantId)
    {
        return await repo.GetByPlantId(plantId);
    }
}
