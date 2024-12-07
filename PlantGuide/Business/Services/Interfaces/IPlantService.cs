using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;

namespace PlantGuide.Business.Services.Interfaces;

public interface IPlantService : ICrud<Plant, CreatePlantDTO>
{
    Task<Plant?> AssignFloweringSeason(CreateFloweringSeasonPlantDTO fsp);
}
