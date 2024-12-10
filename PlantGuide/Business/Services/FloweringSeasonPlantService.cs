using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class FloweringSeasonPlantService : Crud<FloweringSeasonPlant, CreateFloweringSeasonPlantDTO>, IFloweringSeasonPlantService
{
    private readonly IMapper mapper;
    private readonly IFloweringSeasonPlantRepository repo;

    public FloweringSeasonPlantService(IMapper mapper, IFloweringSeasonPlantRepository repo)
        : base(mapper, repo)
    {
        this.mapper = mapper;
        this.repo = repo;
    }

    public async Task<List<FloweringSeasonPlant>> GetByPlantId(int plantId)
    {
        return await repo.GetByPlantId(plantId);
    }
}
