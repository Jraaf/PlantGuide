using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class PlantService : Crud<Plant, CreatePlantDTO>, IPlantService
{
    private readonly IMapper mapper;
    private readonly IPlantRepository repo;

    public PlantService(IMapper _mapper, IPlantRepository _repo)
        : base(_mapper, _repo)
    {
        mapper = _mapper;
        repo = _repo;
    }

    public async Task<Plant?> AssignFloweringSeason(CreateFloweringSeasonPlantDTO fsp)
    {
        var data = mapper.Map<FloweringSeasonPlant>(fsp);
        return await repo.AssignFloweringSeason(data);
    }
}
