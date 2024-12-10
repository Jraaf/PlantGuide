using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;

namespace PlantGuide.Business.Services.Interfaces;

public interface IOriginService : ICrud<Origin, CreateOriginDTO>
{
    Task<List<Origin>> GetByPlantId(int plantId);
}
