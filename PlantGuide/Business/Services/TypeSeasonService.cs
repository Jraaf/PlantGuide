using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class TypeSeasonService : Crud<TypeSeason, CreateTypeSeasonDTO>, ITypeSeasonService
{
    private readonly IMapper mapper;
    private readonly ITypeSeasonRepository repo;

    public TypeSeasonService(IMapper _mapper, ITypeSeasonRepository _repo)
        : base(_mapper, _repo)
    {
        mapper = _mapper;
        repo = _repo;
    }

    public async Task<List<TypeSeason>> GetByPlantId(int plantId)
    {
        return await repo.GetByPlantId(plantId);
    }
}
