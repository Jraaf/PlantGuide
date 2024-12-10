using DataAccess.Models;
using DataAccess.Repository.Base;

namespace PlantGuide.DataAccess.Repository.Interfaces;

public interface IClimateRepository : IRepo<Climate, int>
{
    Task<Climate?> GetByPlantId(int plantId);
}
