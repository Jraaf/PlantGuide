using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class CountryService : Crud<Country, CreateCountryDTO>, ICountryService
{
    public CountryService(IMapper _mapper, ICountryRepository _repo)
        : base(_mapper, _repo)
    {

    }
}
