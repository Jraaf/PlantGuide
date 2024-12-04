using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class PlantService : Crud<Plant, CreatePlantDTO>, IPlantService
{
    public PlantService(IMapper _mapper, IPlantRepository _repo)
        : base(_mapper, _repo)
    {

    }
}
