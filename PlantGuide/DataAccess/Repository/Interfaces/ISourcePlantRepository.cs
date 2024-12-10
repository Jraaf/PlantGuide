using DataAccess.Models;
using DataAccess.Repository.Base;

namespace PlantGuide.DataAccess.Repository.Interfaces;

public interface ISourcePlantRepository : IRepo<SourcePlant, int>
{
    Task<List<SourcePlant>> GetByPlantId(int plantId);
}
