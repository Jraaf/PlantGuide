using DataAccess.Models;
using DataAccess.Repository.Base;

namespace PlantGuide.DataAccess.Repository.Interfaces;

public interface IOriginRepository : IRepo<Origin, int>
{
    Task<List<Origin>> GetByPlantId(int plantId);
}
