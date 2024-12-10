using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class CountryService : Crud<Country, CreateCountryDTO>, ICountryService
{
    private readonly IMapper mapper;
    private readonly ICountryRepository repo;

    public CountryService(IMapper _mapper, ICountryRepository _repo)
        : base(_mapper, _repo)
    {
        mapper = _mapper;
        repo = _repo;
    }

    public async Task<List<Country>> GetByPlantId(int plantId)
    {
        return await repo.GetByPlantId(plantId);
    }
}
