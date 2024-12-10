using AutoMapper;
using DataAccess.Models;
using DataAccess.Repository.Base;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class FamilyService : Crud<Family, CreateFamilyDTO>, IFamilyService
{
    private readonly IMapper mapper;
    private readonly IFamilyRepository repo;

    public FamilyService(IMapper _mapper, IFamilyRepository _repo)
        : base(_mapper, _repo)
    {
        mapper = _mapper;
        repo = _repo;
    }

    public async Task<List<Family>> GetByPlantId(int plantId)
    {
        return await repo.GetByPlantId(plantId);
    }
}
