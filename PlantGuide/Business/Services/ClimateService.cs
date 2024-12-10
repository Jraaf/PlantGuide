using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class ClimateService : Crud<Climate, CreateClimateDTO>, IClimateService
{
    private readonly IMapper mapper;
    private readonly IClimateRepository repo;

    public ClimateService(IMapper _mapper, IClimateRepository _repo)
        : base(_mapper, _repo)
    {
        mapper = _mapper;
        repo = _repo;
    }

    public async Task<Climate?> GetByPlantId(int plantId)
    {
        return await repo.GetByPlantId(plantId);
    }
}
